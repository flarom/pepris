namespace Pepris {
    partial class frmGame {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            pbCanvas = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            timerGameStart = new System.Windows.Forms.Timer(components);
            lblLines = new Label();
            lblTime = new Label();
            pbNextShape = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            timerRun = new System.Windows.Forms.Timer(components);
            lblMessage = new Label();
            lblCombo = new Label();
            pnlStatus = new Panel();
            label4 = new Label();
            pbHoldShape = new PictureBox();
            label3 = new Label();
            timerMove = new System.Windows.Forms.Timer(components);
            timerMoveDelay = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNextShape).BeginInit();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHoldShape).BeginInit();
            SuspendLayout();
            // 
            // pbCanvas
            // 
            pbCanvas.BackColor = Color.FromArgb(32, 32, 32);
            pbCanvas.Location = new Point(0, 0);
            pbCanvas.Margin = new Padding(0);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(300, 400);
            pbCanvas.TabIndex = 0;
            pbCanvas.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 400;
            timer.Tick += timer_Tick;
            // 
            // timerGameStart
            // 
            timerGameStart.Interval = 500;
            timerGameStart.Tick += timerGameStart_Tick;
            // 
            // lblLines
            // 
            lblLines.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLines.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLines.Location = new Point(12, 238);
            lblLines.Name = "lblLines";
            lblLines.Size = new Size(115, 30);
            lblLines.TabIndex = 1;
            lblLines.Text = "00/40";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblTime.Location = new Point(12, 283);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(115, 30);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00";
            // 
            // pbNextShape
            // 
            pbNextShape.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbNextShape.BackColor = Color.FromArgb(32, 32, 32);
            pbNextShape.Location = new Point(12, 27);
            pbNextShape.Name = "pbNextShape";
            pbNextShape.Padding = new Padding(5);
            pbNextShape.Size = new Size(100, 86);
            pbNextShape.TabIndex = 3;
            pbNextShape.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 268);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 223);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "Lines";
            // 
            // timerRun
            // 
            timerRun.Interval = 1;
            timerRun.Tick += timerRun_Tick;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblMessage.Location = new Point(0, 313);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(130, 30);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "lblMessage";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            // 
            // lblCombo
            // 
            lblCombo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCombo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCombo.Location = new Point(0, 343);
            lblCombo.Name = "lblCombo";
            lblCombo.Size = new Size(132, 20);
            lblCombo.TabIndex = 7;
            lblCombo.Text = "lblCombo";
            lblCombo.TextAlign = ContentAlignment.MiddleCenter;
            lblCombo.Visible = false;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.FromArgb(32, 32, 32);
            pnlStatus.Controls.Add(label4);
            pnlStatus.Controls.Add(pbHoldShape);
            pnlStatus.Controls.Add(label3);
            pnlStatus.Controls.Add(pbNextShape);
            pnlStatus.Controls.Add(label2);
            pnlStatus.Controls.Add(label1);
            pnlStatus.Controls.Add(lblTime);
            pnlStatus.Controls.Add(lblCombo);
            pnlStatus.Controls.Add(lblLines);
            pnlStatus.Controls.Add(lblMessage);
            pnlStatus.Dock = DockStyle.Right;
            pnlStatus.Location = new Point(300, 0);
            pnlStatus.Margin = new Padding(0);
            pnlStatus.MinimumSize = new Size(130, 400);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(130, 400);
            pnlStatus.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 10;
            label4.Text = "Hold";
            // 
            // pbHoldShape
            // 
            pbHoldShape.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbHoldShape.BackColor = Color.FromArgb(32, 32, 32);
            pbHoldShape.Location = new Point(12, 134);
            pbHoldShape.Name = "pbHoldShape";
            pbHoldShape.Padding = new Padding(5);
            pbHoldShape.Size = new Size(100, 86);
            pbHoldShape.TabIndex = 9;
            pbHoldShape.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "Next";
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(430, 400);
            Controls.Add(pbCanvas);
            Controls.Add(pnlStatus);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGame";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pepris";
            FormClosing += frmGame_FormClosing;
            Load += frmGame_Load;
            LocationChanged += frmGame_LocationChanged;
            KeyDown += frmGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbCanvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNextShape).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHoldShape).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCanvas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerGameStart;
        private Label lblLines;
        private Label lblTime;
        private PictureBox pbNextShape;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timerRun;
        private Label lblMessage;
        private Label lblCombo;
        private Panel pnlStatus;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Timer timerMoveDelay;
        private Label label3;
        private Label label4;
        private PictureBox pbHoldShape;
    }
}
