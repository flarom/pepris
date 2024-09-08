namespace Pepris {
    public partial class frmGame : Form {
        int lines;
        int playTime;

        Sounds sounds = new Sounds();
        Settings settings = new Settings();

        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        int canvasWidth = 10;
        int canvasHeight = 20;
        int[,] canvasDotArray;
        int dotSize = 20;

        int currentX;
        int currentY;
        bool holdUsed = false;
        Shape currentShape;
        Shape nextShape;
        Shape holdShape;

        Bitmap holdShapeBitmap;
        Graphics holdShapeGraphics;
        Bitmap nextShapeBitmap;
        Graphics nextShapeGraphics;

        static Color backgroundColor = Color.FromArgb(32, 32, 32);
        Color foregroundColor = Color.White;
        SolidBrush backgroundBrush = new SolidBrush(backgroundColor);
        SolidBrush foregroundBrush;

        Form status = new Form();
        public frmMenu menu;

        public frmGame(Color forecolor) {
            InitializeComponent();

            foregroundColor = forecolor;
            foregroundBrush = new SolidBrush(forecolor);
            dotSize = settings.GetSettingInt("pointSize");

            loadCanvas();

            timerGameStart.Start();
        }
        private void loadCanvas() {
            pbCanvas.Width = canvasWidth * dotSize;
            pbCanvas.Height = canvasHeight * dotSize;

            canvasBitmap = new Bitmap(pbCanvas.Width, pbCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);

            canvasGraphics.FillRectangle(backgroundBrush, 0, 0, canvasBitmap.Width, canvasBitmap.Height);

            pbCanvas.Image = canvasBitmap;

            canvasDotArray = new int[canvasWidth, canvasHeight];
        }

        private Shape getRandomShape() {
            var shape = ShapesHandler.GetRandomShape();

            currentX = 4;
            currentY = -shape.Height + 1;

            return shape;
        }
        private Shape getNextShape() {
            var shape = getRandomShape();

            while (shape == currentShape) {
                shape = getRandomShape();
            }

            nextShapeBitmap = new Bitmap(6 * dotSize, 6 * dotSize);
            nextShapeGraphics = Graphics.FromImage(nextShapeBitmap);

            nextShapeGraphics.FillRectangle(backgroundBrush, 0, 0, nextShapeBitmap.Width, nextShapeBitmap.Height);

            var startX = (3 - shape.Width) / 2;
            var startY = (3 - shape.Height) / 2;

            for (int i = 0; i < shape.Height; i++) {
                for (int j = 0; j < shape.Width; j++) {
                    nextShapeGraphics.FillRectangle(
                        shape.Dots[i, j] == 1 ? foregroundBrush : backgroundBrush,
                        (startX + j) * dotSize, (startY + i) * dotSize, dotSize, dotSize);
                }
            }

            resetHoldUsage();
            pbNextShape.Image = nextShapeBitmap;

            return shape;
        }

        private void setHoldShape() {
            if (holdUsed)
                return;

            Shape temp = currentShape;
            currentShape = holdShape ?? nextShape;
            holdShape = temp;

            if (holdShape == null) {
                nextShape = getNextShape();
            }

            if (!isValidPosition(currentX, currentY)) {
                if (isValidPosition(currentX - 1, currentY)) {
                    currentX -= 1;
                }
                else if (isValidPosition(currentX + 1, currentY)) {
                    currentX += 1;
                }
            }

            drawHoldShape();

            holdUsed = true;
        }

        private bool isValidPosition(int x, int y) {
            for (int i = 0; i < currentShape.Width; i++) {
                for (int j = 0; j < currentShape.Height; j++) {
                    if (currentShape.Dots[j, i] == 1) {
                        if (x + i < 0 || x + i >= canvasWidth || y + j >= canvasHeight ||
                            (y + j >= 0 && canvasDotArray[x + i, y + j] == 1)) {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool isValidRotation() {
            for (int i = 0; i < currentShape.Width; i++) {
                for (int j = 0; j < currentShape.Height; j++) {
                    int newX = currentX + i;
                    int newY = currentY + j;

                    if (newX < 0 || newX >= canvasWidth || newY >= canvasHeight)
                        return false;

                    if (newY >= 0 && canvasDotArray[newX, newY] == 1 && currentShape.Dots[j, i] == 1)
                        return false;
                }
            }
            return true;
        }
        private void resetHoldUsage() {
            holdUsed = false;
        }
        private bool rotateShape() {
            currentShape.turn();

            if (isValidRotation())
                return true;

            for (int offset = 1; offset <= currentShape.Width; offset++) {
                if (moveShape(0, -offset) && isValidRotation())
                    return true;

                moveShape(0, offset);
            }

            for (int offset = 1; offset <= currentShape.Width; offset++) {
                if (moveShape(0, offset) && isValidRotation())
                    return true;

                moveShape(0, -offset);
            }

            currentShape.rollback();
            return false;
        }
        private bool moveShape(int moveDown = 0, int moveSide = 0) {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;

            if (newX < 0 || newX + currentShape.Width > canvasWidth
                || newY + currentShape.Height > canvasHeight) {
                impulse(5, 0);
                return false;
            }

            for (int i = 0; i < currentShape.Width; i++) {
                for (int j = 0; j < currentShape.Height; j++) {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && currentShape.Dots[j, i] == 1) {
                        return false;
                    }
                }
            }

            currentX = newX;
            currentY = newY;

            drawShape();

            return true;
        }
        private void dropDown() {
            while (moveShape(1, 0)) { }

            var isMoveSuccess = moveShape(moveDown: 1);

            if (!isMoveSuccess) {
                canvasBitmap = new Bitmap(workingBitmap);

                updateCanvasDotArray();

                currentShape = nextShape;
                nextShape = getNextShape();

                clearFilledRowsAndUpdateScore();
            }

            impulse(0, 5);
        }
        private (int finalX, int finalY) calculateDropPosition() {
            int tempX = currentX;
            int tempY = currentY;

            while (true) {
                var newY = tempY + 1;
                if (!isValidPosition(tempX, newY)) break;
                tempY = newY;
            }

            return (tempX, tempY);
        }

        Bitmap workingBitmap;
        Graphics workingGraphics;

        private void drawShape() {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);

            var (finalX, finalY) = calculateDropPosition();
            for (int i = 0; i < currentShape.Width; i++) {
                for (int j = 0; j < currentShape.Height; j++) {
                    if (currentShape.Dots[j, i] == 1) {
                        workingGraphics.FillRectangle(Brushes.Gray, (finalX + i) * dotSize, (finalY + j) * dotSize, dotSize, dotSize);
                    }
                }
            }

            for (int i = 0; i < currentShape.Width; i++) {
                for (int j = 0; j < currentShape.Height; j++) {
                    if (currentShape.Dots[j, i] == 1)
                        workingGraphics.FillRectangle(foregroundBrush, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                }
            }

            pbCanvas.Image = workingBitmap;
        }
        private void drawHoldShape() {
            holdShapeBitmap = new Bitmap(6 * dotSize, 6 * dotSize);
            holdShapeGraphics = Graphics.FromImage(holdShapeBitmap);
            holdShapeGraphics.FillRectangle(backgroundBrush, 0, 0, holdShapeBitmap.Width, holdShapeBitmap.Height);

            var startX = (3 - holdShape.Width) / 2;
            var startY = (3 - holdShape.Height) / 2;

            for (int i = 0; i < holdShape.Height; i++) {
                for (int j = 0; j < holdShape.Width; j++) {
                    holdShapeGraphics.FillRectangle(
                        holdShape.Dots[i, j] == 1 ? foregroundBrush : backgroundBrush,
                        (startX + j) * dotSize, (startY + i) * dotSize, dotSize, dotSize);
                }
            }

            pbHoldShape.Image = holdShapeBitmap;
        }
        private void updateCanvasDotArray() {
            for (int i = 0; i < currentShape.Width; i++) {
                for (int j = 0; j < currentShape.Height; j++) {
                    if (currentShape.Dots[j, i] == 1) {
                        if (isGameOver()) {
                            gameOver();
                            return;
                        }

                        canvasDotArray[currentX + i, currentY + j] = 1;
                    }
                }
            }
        }
        private bool isGameOver() {
            if (currentY < 0) {
                return true;
            }
            return false;
        }

        private void gameOver() {
            sounds.Play(sounds.error);
            timerRun.Stop();
            timer.Stop();
            MessageBox.Show("You cleared " + lines + " lines before dying", "You lost!");
            Close();
        }
        private void gameWin() {
            timerRun.Stop();
            timer.Stop();
            status.Close();
            frmPostGame postgame = new();
            postgame.primary = foregroundColor;
            postgame.playTime = getTimeString(playTime);
            postgame.playMillis = playTime;
            postgame.lines = lines;
            postgame.ShowDialog();
            Close();
        }
        private void timer_Tick(object sender, EventArgs e) {
            var isMoveSuccess = moveShape(moveDown: 1);

            if (!isMoveSuccess) {
                canvasBitmap = new Bitmap(workingBitmap);

                updateCanvasDotArray();

                currentShape = nextShape;
                nextShape = getNextShape();

                clearFilledRowsAndUpdateScore();
            }
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e) {
            var verticalMove = 0;
            var horizontalMove = 0;

            switch (e.KeyCode) {
                case Keys.Left:
                case Keys.NumPad4:
                    verticalMove--;
                    break;

                case Keys.Right:
                case Keys.NumPad6:
                    verticalMove++;
                    break;

                case Keys.Down:
                case Keys.NumPad2:
                    horizontalMove++;
                    break;

                case Keys.Up:
                case Keys.NumPad5:
                    rotateShape();
                    break;

                case Keys.Space:
                case Keys.NumPad8:
                    dropDown();
                    break;

                case Keys.ShiftKey:
                case Keys.NumPad0:
                    setHoldShape();
                    break;

                case Keys.Escape:
                    timerGameStart.Stop();
                    timer.Stop();
                    timerRun.Stop();
                    Close();
                    return;

                default:
                    return;
            }

            var isMoveSuccess = moveShape(horizontalMove, verticalMove);

            if (!isMoveSuccess && e.KeyCode == Keys.Up) {
                currentShape.rollback();
            }
        }

        int comboCount = 0;
        public void clearFilledRowsAndUpdateScore() {
            int linesClearedNow = 0;

            for (int i = 0; i < canvasHeight; i++) {
                int j;
                for (j = canvasWidth - 1; j >= 0; j--) {
                    if (canvasDotArray[j, i] == 0)
                        break;
                }

                if (j == -1) {
                    linesClearedNow++;
                    lines++;
                    lblLines.Text = string.Format("{0:00}", lines) + "/40";

                    for (j = 0; j < canvasWidth; j++) {
                        for (int k = i; k > 0; k--) {
                            canvasDotArray[j, k] = canvasDotArray[j, k - 1];
                        }
                        canvasDotArray[j, 0] = 0;
                    }
                }
            }

            if (linesClearedNow > 0) {
                switch (linesClearedNow) {
                    case 1:
                        displayMessage("Single", 2000);
                        break;
                    case 2:
                        displayMessage("Double", 2000);
                        break;
                    case 3:
                        displayMessage("Triple", 2000);
                        break;
                    case 4:
                        displayMessage("Quad", 2000);
                        break;
                }

                comboCount++;
                if (comboCount >= 2) {
                    displayComboMessage($"Combo x{comboCount}!", 2000);
                }
                switch (comboCount) {
                    case 1:
                        sounds.Play(sounds.combo1);
                        break;
                    case 2:
                        sounds.Play(sounds.combo2);
                        break;
                    case 3:
                        sounds.Play(sounds.combo3);
                        break;
                    case 4:
                        sounds.Play(sounds.combo4);
                        break;
                    default:
                        sounds.Play(sounds.combo5);
                        break;
                }

            }
            else {
                comboCount = 0;
            }

            for (int i = 0; i < canvasWidth; i++) {
                for (int j = 0; j < canvasHeight; j++) {
                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    canvasGraphics.FillRectangle(
                        canvasDotArray[i, j] == 1 ? foregroundBrush : backgroundBrush,
                        i * dotSize, j * dotSize, dotSize, dotSize
                    );
                }
            }

            pbCanvas.Image = canvasBitmap;

            if (lines >= 40) {
                gameWin();
                return;
            }
        }

        int remainingTime = 4;
        private void timerGameStart_Tick(object sender, EventArgs e) {
            remainingTime--;
            displayMessage(remainingTime.ToString(), 400);

            if (remainingTime == 0) {
                timerGameStart.Stop();
                timer.Start();
                timerRun.Start();

                currentShape = getRandomShape();
                nextShape = getNextShape();
                sounds.Play(sounds.forward);
            }
            else {
                sounds.Play(sounds.hover);
            }
        }
        private void frmGame_FormClosing(object sender, EventArgs e) {
            timer.Stop();
            timerGameStart.Stop();
            status.Close();
            sounds.Play(sounds.back);
        }

        private void timerRun_Tick(object sender, EventArgs e) {
            playTime++;
            lblTime.Text = getTimeString(playTime);
        }

        public string getTimeString(int milliseconds) {
            int totalSeconds = milliseconds / 60;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;

            return $"{minutes:D2}:{seconds:D2}";
        }

        private async void displayMessage(string message, int duration) {
            lblMessage.Text = message;
            lblMessage.Visible = true;

            for (int i = 0; i <= 255; i += 5) {
                lblMessage.ForeColor = Color.FromArgb(255, 255, i);
                await Task.Delay(5);
            }

            await Task.Delay(duration);

            for (int i = 255; i >= 32; i -= 5) {
                lblMessage.ForeColor = Color.FromArgb(i, i, i);
                await Task.Delay(10);
            }

            lblMessage.Visible = false;
        }
        private async void displayComboMessage(string message, int duration) {
            lblCombo.Text = message;
            lblCombo.Visible = true;
            lblCombo.ForeColor = Color.White;

            await Task.Delay(duration);

            for (int i = 255; i >= 32; i -= 5) {
                lblCombo.ForeColor = Color.FromArgb(i, i, i);
                await Task.Delay(10);
            }

            lblCombo.Visible = false;
        }

        private CancellationTokenSource impulseCancellationTokenSource;
        private async void impulse(int x, int y) {
            if (!settings.GetSettingBool("boardBounce")) {
                return;
            }

            if (impulseCancellationTokenSource != null) {
                impulseCancellationTokenSource.Cancel();
            }

            impulseCancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = impulseCancellationTokenSource.Token;

            Point initialPosition = this.Location;

            int directionX = x > 0 ? 1 : (x < 0 ? -1 : 0);
            int directionY = y > 0 ? 1 : (y < 0 ? -1 : 0);

            Point targetPosition = new Point(initialPosition.X + x, initialPosition.Y + y);

            try {
                while (this.Location != targetPosition) {
                    if (token.IsCancellationRequested) break;
                    this.Location = new Point(this.Location.X + directionX, this.Location.Y + directionY);
                    await Task.Delay(1, token);
                }

                while (this.Location != initialPosition) {
                    if (token.IsCancellationRequested) break;
                    this.Location = new Point(this.Location.X - directionX, this.Location.Y - directionY);
                    await Task.Delay(1, token);
                }
            }
            catch {
            }
        }


        private async void frmGame_LocationChanged(object sender, EventArgs e) {
            await Task.Delay(1);
            status.Location = new Point(this.Location.X + this.Width - 10, this.Location.Y + (this.Height / 2) - (status.Height / 2));
        }
        private void frmGame_Load(object sender, EventArgs e) {
            WindowEffects.useDarkBorder(this.Handle, true);
            status.Controls.Add(pnlStatus);
            status.BackColor = Color.FromArgb(32, 32, 32);
            status.ForeColor = foregroundColor;
            status.ShowIcon = false;
            status.ControlBox = false;
            status.ShowInTaskbar = false;
            WindowEffects.useDarkBorder(status.Handle, true);
            status.TopMost = true;
            status.Opacity = this.Opacity;
            status.Show();
            status.Size = new Size(130, this.Size.Height - 30);
            status.MaximumSize = status.Size;
            status.MinimumSize = status.Size;
            status.Location = new Point(this.Location.X + this.Width -10, this.Location.Y + (this.Height / 2) - (status.Height / 2));
        }
    }
}

