namespace Pepris {
    partial class frmMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            btnPlay = new Button();
            btnOptions = new Button();
            btnQuit = new Button();
            panel1 = new Panel();
            btnScore = new Button();
            pbBackground = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.Image = Properties.Resources.fullLogoMonoBig;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 83);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(32, 32, 32);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.Dock = DockStyle.Top;
            btnPlay.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnPlay.ImageAlign = ContentAlignment.MiddleRight;
            btnPlay.Location = new Point(0, 83);
            btnPlay.Margin = new Padding(3, 0, 3, 0);
            btnPlay.Name = "btnPlay";
            btnPlay.Padding = new Padding(20, 0, 10, 0);
            btnPlay.Size = new Size(290, 47);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.TextAlign = ContentAlignment.MiddleLeft;
            btnPlay.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += button1_Click;
            btnPlay.Enter += ButtonFocused;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.FromArgb(32, 32, 32);
            btnOptions.Cursor = Cursors.Hand;
            btnOptions.Dock = DockStyle.Top;
            btnOptions.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnOptions.ImageAlign = ContentAlignment.MiddleRight;
            btnOptions.Location = new Point(0, 130);
            btnOptions.Margin = new Padding(3, 0, 3, 0);
            btnOptions.Name = "btnOptions";
            btnOptions.Padding = new Padding(20, 0, 10, 0);
            btnOptions.Size = new Size(290, 47);
            btnOptions.TabIndex = 2;
            btnOptions.Text = "Options";
            btnOptions.TextAlign = ContentAlignment.MiddleLeft;
            btnOptions.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            btnOptions.Enter += ButtonFocused;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(32, 32, 32);
            btnQuit.Cursor = Cursors.Hand;
            btnQuit.Dock = DockStyle.Top;
            btnQuit.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnQuit.ImageAlign = ContentAlignment.MiddleRight;
            btnQuit.Location = new Point(0, 224);
            btnQuit.Margin = new Padding(3, 0, 3, 0);
            btnQuit.Name = "btnQuit";
            btnQuit.Padding = new Padding(20, 0, 10, 0);
            btnQuit.Size = new Size(290, 47);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.TextAlign = ContentAlignment.MiddleLeft;
            btnQuit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += button3_Click;
            btnQuit.Enter += ButtonFocused;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(btnQuit);
            panel1.Controls.Add(btnScore);
            panel1.Controls.Add(btnOptions);
            panel1.Controls.Add(btnPlay);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 350);
            panel1.TabIndex = 4;
            // 
            // btnScore
            // 
            btnScore.BackColor = Color.FromArgb(32, 32, 32);
            btnScore.Cursor = Cursors.Hand;
            btnScore.Dock = DockStyle.Top;
            btnScore.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnScore.FlatAppearance.BorderSize = 0;
            btnScore.FlatStyle = FlatStyle.Flat;
            btnScore.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnScore.ImageAlign = ContentAlignment.MiddleRight;
            btnScore.Location = new Point(0, 177);
            btnScore.Margin = new Padding(3, 0, 3, 0);
            btnScore.Name = "btnScore";
            btnScore.Padding = new Padding(20, 0, 10, 0);
            btnScore.Size = new Size(290, 47);
            btnScore.TabIndex = 3;
            btnScore.Text = "Scoreboard";
            btnScore.TextAlign = ContentAlignment.MiddleLeft;
            btnScore.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click;
            btnScore.Enter += ButtonFocused;
            // 
            // pbBackground
            // 
            pbBackground.BackColor = Color.FromArgb(40, 40, 40);
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Location = new Point(0, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(290, 350);
            pbBackground.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBackground.TabIndex = 7;
            pbBackground.TabStop = false;
            pbBackground.Click += pbBackground_DoubleClick;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(290, 350);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pbBackground);
            ForeColor = Color.White;
            MinimumSize = new Size(306, 366);
            Name = "frmMenu";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnPlay;
        private Button btnOptions;
        private Button btnQuit;
        private Panel panel1;
        private Button btnScore;
        private PictureBox pbBackground;
    }
}