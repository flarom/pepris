namespace Pepris {
    public partial class frmPostGame : Form {
        public int lines;
        public int playMillis;
        public string playTime;
        public Color primary = Color.White;

        Sounds sounds = new();
        public frmPostGame() {
            InitializeComponent();
            WindowEffects.useDarkBorder(this.Handle, true);
        }

        private async void frmPostGame_Load(object sender, EventArgs e) {
            lblTime.Text = playTime;
            Opacity = 0;

            while (Opacity < 1) {
                Opacity += 0.1;
                await Task.Delay(1);
            }
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

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Scores score = new Scores();
            dlgInput input = new dlgInput();
            string playerName = input.getInput("Save score", "Enter the player name", Environment.UserName, true, "person");

            if (input.DialogResult == DialogResult.Cancel) return;

            score.SaveScore(DateTime.Now, playMillis, lines, playerName);
            sounds.Play(sounds.save);
        }
    }
}
