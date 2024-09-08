using Pepris.Properties;

namespace Pepris {
    public partial class frmMenu : Form {
        Sounds sounds = new();
        Settings settings = new();
        WindowsSymbols symbols = new WindowsSymbols();
        dlgSelect select = new dlgSelect();
        Color primary = Color.White;
        public frmMenu() {
            InitializeComponent();
            WindowEffects.useDarkBorder(this.Handle, true);
            if (settings.GetSettingBool("useBackground")) {
                WindowState = FormWindowState.Maximized;
                ControlBox = true;
                Text = "Pepris";
                loadBackground();
            }
            else {
                Size = panel1.Size;
            }
        }
        private void loadBackground() {
            string[] images = settings.GetSettingStringArray("backgrounds");

            if (images.Length > 0) {
                Random rnd = new Random();
                string selectedImage = images[rnd.Next(images.Length)];

                if (File.Exists(selectedImage)) {
                    pbBackground.ImageLocation = selectedImage;
                }
                else if (Directory.Exists(selectedImage)) {
                    string[] imageFiles = Directory.GetFiles(selectedImage)
                                                   .Where(file => settings.validBackgroundExtensions.Contains(Path.GetExtension(file).ToLower()))
                                                   .ToArray();

                    if (imageFiles.Length > 0) {
                        pbBackground.ImageLocation = imageFiles[rnd.Next(imageFiles.Length)];
                    }
                    else {
                        pbBackground.Image = pbBackground.ErrorImage;
                        return;
                    }
                }
                else if (Uri.IsWellFormedUriString(selectedImage, UriKind.Absolute)) {
                    try {
                        pbBackground.ImageLocation = selectedImage;
                    }
                    catch {
                        pbBackground.Image = pbBackground.ErrorImage;
                        return;
                    }
                }
                else {
                    pbBackground.Image = pbBackground.ErrorImage;
                    return;
                }

                pbBackground.Load();
                if (settings.GetSettingBool("allowCustomBgColors")) {
                    using (Bitmap bmp = new Bitmap(pbBackground.Image)) {
                        int maxAttempts = 50;

                        for (int i = 0; i < maxAttempts; i++) {
                            int x = rnd.Next(bmp.Width);
                            int y = rnd.Next(bmp.Height);
                            Color selectedColor = bmp.GetPixel(x, y);

                            if (selectedColor.GetBrightness() >= 0.5) {
                                primary = selectedColor;
                                break;
                            }
                        }
                        panel1.ForeColor = primary;
                        label1.Image = symbols.TintImage(Resources.fullLogoMonoBig, primary);
                    }
                }
            }
            else {
                pbBackground.Image = pbBackground.ErrorImage;
            }
        }
        public async void FadeOut() {
            btnPlay.Enabled = false;
            btnOptions.Enabled = false;
            btnScore.Enabled = false;
            btnQuit.Enabled = false;
            for (double i = 1; i >= 0; i = i - 0.1) {
                Opacity = i;
                await Task.Delay(1);
            }
        }
        public async void FadeOutAndClose() {
            btnPlay.Enabled = false;
            btnOptions.Enabled = false;
            btnScore.Enabled = false;
            btnQuit.Enabled = false;
            if (WindowState == FormWindowState.Normal) {
                MinimumSize = new Size(0, 0);
                panel1.Anchor = AnchorStyles.None;
                panel1.Dock = DockStyle.None;
            }
            else {
                HidePanel();
                await Task.Delay(750);
            }
            for (double i = 1; i > 0; i = i - 0.02) {
                Opacity = i;
                Size = new Size(Size.Width - 2, Size.Height - 2);
                Location = new Point(Location.X + 1, Location.Y + 1);
                await Task.Delay(1);
            }
            this.Close();
        }
        public async void HidePanel() {
            int initialWidth = panel1.Width;
            int steps = 25;
            for (int step = 0; step <= steps; step++) {
                double t = (double)step / steps;
                double easeValue = EaseInOut(t);
                int currentWidth = (int)(initialWidth * (1 - easeValue));
                panel1.Size = new Size(currentWidth, panel1.Height);
                await Task.Delay(10);
            }
        }

        public async void ShowPanel() {
            int targetWidth = 290;
            int steps = 25;
            for (int step = 0; step <= steps; step++) {
                double t = (double)step / steps;
                double easeValue = EaseInOut(t);
                int currentWidth = (int)(targetWidth * easeValue);
                panel1.Size = new Size(currentWidth, panel1.Height);
                await Task.Delay(10);
            }
        }

        private double EaseInOut(double t) {
            return t < 0.5 ? 2 * t * t : 1 - Math.Pow(-2 * t + 2, 2) / 2;
        }
        private void button1_Click(object sender, EventArgs e) {
            sounds.Play(sounds.forward);

            int selectedMode = select.getAnswer(["40 Lines time trial", "Blitz","Multiplayer battle"], ["clock", "speedometer", "people"], "Available game modes");
            if (select.DialogResult == DialogResult.Cancel) return;

            if (!settings.GetSettingBool("useBackground")) {
                FadeOut();
            }
            else {
                HidePanel();
            }

            frmGame game = new frmGame(primary);
            game.menu = this;
            game.Opacity = settings.GetSettingDouble("boardOpacity");
            game.ShowDialog();

            ShowPanel();
            Opacity = 1;
            btnPlay.Enabled = true;
            btnOptions.Enabled = true;
            btnScore.Enabled = true;
            btnQuit.Enabled = true;
        }
        private void btnOptions_Click(object sender, EventArgs e) {
            sounds.Play(sounds.forward);

            if (!settings.GetSettingBool("useBackground")) {
                FadeOut();
            }
            else {
                HidePanel();
            }

            frmConfig Conf = new frmConfig();
            Conf.primary = primary;
            Conf.ShowDialog();

            ShowPanel();
            Opacity = 1;
            btnPlay.Enabled = true;
            btnOptions.Enabled = true;
            btnScore.Enabled = true;
            btnQuit.Enabled = true;
        }
        private async void btnScore_Click(object sender, EventArgs e) {
            sounds.Play(sounds.forward);

            if (!settings.GetSettingBool("useBackground")) {
                FadeOut();
            }
            else {
                HidePanel();
            }

            frmScore Score = new frmScore();
            Score.ForeColor = primary;
            Score.ShowDialog();

            ShowPanel();
            Opacity = 1;
            btnPlay.Enabled = true;
            btnOptions.Enabled = true;
            btnScore.Enabled = true;
            btnQuit.Enabled = true;
        }
        private async void button3_Click(object sender, EventArgs e) {
            sounds.Play(sounds.back);
            FadeOutAndClose();
        }

        private async void ButtonFocused(object sender, EventArgs e) {
            foreach (Control con in panel1.Controls) {
                if (con is Button unfocused) {
                    unfocused.BackColor = Color.FromArgb(32, 32, 32);
                    unfocused.ForeColor = primary;
                    unfocused.Padding = new Padding(20, 0, 0, 0);
                }
            }
            if (sender is Button focused) {
                focused.BackColor = primary;
                focused.ForeColor = Color.FromArgb(32, 32, 32);
                for (int i = 20; i <= 40; i += 2) {
                    focused.Padding = new Padding(i, 0, 0, 0);
                    await Task.Delay(1);
                }
            }
        }

        private void pbBackground_DoubleClick(object sender, EventArgs e) {
            loadBackground();
        }
    }
}
