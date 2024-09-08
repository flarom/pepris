namespace Pepris {
    partial class frmPostGame {
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
            dialogTitleBar1 = new Controls.DialogTitleBar();
            lblTime = new Label();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            panel1 = new Panel();
            btnShare = new Button();
            btnSave = new Button();
            btnPlay = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dialogTitleBar1
            // 
            dialogTitleBar1.BackColor = Color.FromArgb(32, 32, 32);
            dialogTitleBar1.CanMove = true;
            dialogTitleBar1.Dock = DockStyle.Top;
            dialogTitleBar1.ForeColor = Color.White;
            dialogTitleBar1.Location = new Point(0, 0);
            dialogTitleBar1.Name = "dialogTitleBar1";
            dialogTitleBar1.Size = new Size(369, 30);
            dialogTitleBar1.TabIndex = 0;
            dialogTitleBar1.TabStop = false;
            dialogTitleBar1.Title = "Pepris";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(101, 34);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(153, 65);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(lblTime);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(7, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 131);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Final time";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Top;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnClose.Location = new Point(0, 141);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(369, 47);
            btnClose.TabIndex = 3;
            btnClose.Text = "Go back";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            btnClose.Enter += ButtonFocused;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnShare);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnPlay);
            panel1.Location = new Point(0, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 192);
            panel1.TabIndex = 0;
            // 
            // btnShare
            // 
            btnShare.Dock = DockStyle.Top;
            btnShare.FlatAppearance.BorderSize = 0;
            btnShare.FlatStyle = FlatStyle.Flat;
            btnShare.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnShare.Location = new Point(0, 94);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(369, 47);
            btnShare.TabIndex = 2;
            btnShare.Text = "Share";
            btnShare.TextAlign = ContentAlignment.MiddleLeft;
            btnShare.UseVisualStyleBackColor = true;
            btnShare.Enter += ButtonFocused;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Top;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnSave.Location = new Point(0, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(369, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            btnSave.Enter += ButtonFocused;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.White;
            btnPlay.Dock = DockStyle.Top;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnPlay.ForeColor = Color.FromArgb(32, 32, 32);
            btnPlay.Location = new Point(0, 0);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(369, 47);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play again";
            btnPlay.TextAlign = ContentAlignment.MiddleLeft;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Enter += ButtonFocused;
            // 
            // frmPostGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(369, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dialogTitleBar1);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(385, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(385, 466);
            Name = "frmPostGame";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmPostGame_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.DialogTitleBar dialogTitleBar1;
        private Label lblTime;
        private GroupBox groupBox1;
        private Button btnClose;
        private Panel panel1;
        private Button btnShare;
        private Button btnSave;
        private Button btnPlay;
    }
}