namespace Pepris {
    public partial class frmScore : Form {
        Sounds Sounds = new Sounds();
        Scores Scores = new Scores();
        public frmScore() {
            InitializeComponent();
            string[] scores = Scores.GetAllScoresPaths();
            foreach (string score in scores) {
                string[] info = Scores.LoadScore(score);
                ListViewItem item = new ListViewItem([getTimeString(int.Parse(info[1])), info[2], info[3], info[0]]);
                listScores.Items.Add(item);
            }
            colDate.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            WindowEffects.useDarkBorder(this.Handle, true);
        }

        private void frmScore_FormClosing(object sender, FormClosingEventArgs e) {
            Sounds.Play(Sounds.back);
        }
        public string getTimeString(int milliseconds) {
            int totalSeconds = milliseconds / 60;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;

            return $"{minutes:D2}:{seconds:D2}";
        }

        private void listScores_DrawItem(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
        }

        private void listScores_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            using (Font headerFont = new Font("Segoe UI", 14, FontStyle.Regular)) {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 32, 32)), e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont, e.Bounds, this.ForeColor, TextFormatFlags.Left);
            }
        }

        private void listScores_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            using (Font itemFont = new Font("Segoe UI", 10)) {
                Rectangle paddedBounds = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 10, e.Bounds.Height - 10);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 32, 32)), paddedBounds);
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, itemFont, paddedBounds, this.ForeColor, TextFormatFlags.Left);
            }
        }

        private void frmScore_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) {
                Close();
            }
        }
    }
}
