namespace Pepris {
    partial class frmScore {
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
            listScores = new ListView();
            colTime = new ColumnHeader();
            colLines = new ColumnHeader();
            colPlayer = new ColumnHeader();
            colDate = new ColumnHeader();
            dialogTitle1 = new Controls.DialogTitleBar();
            SuspendLayout();
            // 
            // listScores
            // 
            listScores.BackColor = Color.FromArgb(32, 32, 32);
            listScores.BorderStyle = BorderStyle.None;
            listScores.Columns.AddRange(new ColumnHeader[] { colTime, colLines, colPlayer, colDate });
            listScores.Dock = DockStyle.Fill;
            listScores.ForeColor = Color.White;
            listScores.Location = new Point(0, 30);
            listScores.Name = "listScores";
            listScores.OwnerDraw = true;
            listScores.Size = new Size(409, 400);
            listScores.Sorting = SortOrder.Ascending;
            listScores.TabIndex = 0;
            listScores.TabStop = false;
            listScores.UseCompatibleStateImageBehavior = false;
            listScores.View = View.Details;
            listScores.DrawColumnHeader += listScores_DrawColumnHeader;
            listScores.DrawItem += listScores_DrawItem;
            listScores.DrawSubItem += listScores_DrawSubItem;
            // 
            // colTime
            // 
            colTime.Text = "Time";
            // 
            // colLines
            // 
            colLines.Text = "Lines";
            // 
            // colPlayer
            // 
            colPlayer.Text = "Player";
            colPlayer.Width = 145;
            // 
            // colDate
            // 
            colDate.Text = "Date";
            colDate.Width = 128;
            // 
            // dialogTitle1
            // 
            dialogTitle1.BackColor = Color.FromArgb(32, 32, 32);
            dialogTitle1.CanAutoClose = true;
            dialogTitle1.CanMove = true;
            dialogTitle1.Dock = DockStyle.Top;
            dialogTitle1.ForeColor = Color.White;
            dialogTitle1.Location = new Point(0, 0);
            dialogTitle1.Name = "dialogTitle1";
            dialogTitle1.Size = new Size(409, 30);
            dialogTitle1.TabIndex = 1;
            dialogTitle1.Title = "Scoreboard";
            // 
            // frmScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(409, 430);
            ControlBox = false;
            Controls.Add(listScores);
            Controls.Add(dialogTitle1);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(425, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(425, 100);
            Name = "frmScore";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += frmScore_FormClosing;
            KeyDown += frmScore_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private ListView listScores;
        private ColumnHeader colDate;
        private ColumnHeader colTime;
        private ColumnHeader colLines;
        private ColumnHeader colPlayer;
        private Controls.DialogTitleBar dialogTitle1;
    }
}