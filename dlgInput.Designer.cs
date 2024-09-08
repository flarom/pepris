namespace Pepris {
    partial class dlgInput {
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
            panel1 = new Panel();
            txtInput = new TextBox();
            btnOk = new Button();
            dialogTitleBar1 = new Controls.DialogTitleBar();
            lblIcon = new Label();
            lblDescription = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 32);
            panel1.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(32, 32, 32);
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Dock = DockStyle.Fill;
            txtInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(0, 0);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(328, 18);
            txtInput.TabIndex = 1;
            txtInput.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            btnOk.Dock = DockStyle.Right;
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe Fluent Icons", 12F);
            btnOk.Location = new Point(328, 0);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(32, 32);
            btnOk.TabIndex = 1;
            btnOk.Text = "";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dialogTitleBar1
            // 
            dialogTitleBar1.BackColor = Color.FromArgb(32, 32, 32);
            dialogTitleBar1.CanAutoClose = false;
            dialogTitleBar1.CanMove = false;
            dialogTitleBar1.Dock = DockStyle.Top;
            dialogTitleBar1.ForeColor = Color.White;
            dialogTitleBar1.Location = new Point(0, 0);
            dialogTitleBar1.Name = "dialogTitleBar1";
            dialogTitleBar1.Size = new Size(360, 30);
            dialogTitleBar1.TabIndex = 3;
            dialogTitleBar1.Title = "Input";
            dialogTitleBar1.CloseCall += dialogTitleBar1_CloseCall;
            // 
            // lblIcon
            // 
            lblIcon.Dock = DockStyle.Left;
            lblIcon.Font = new Font("Segoe UI", 27.75F);
            lblIcon.Location = new Point(0, 30);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(80, 102);
            lblIcon.TabIndex = 4;
            lblIcon.Text = "sym";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(80, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(280, 102);
            lblDescription.TabIndex = 5;
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dlgInput
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(360, 164);
            ControlBox = false;
            Controls.Add(lblDescription);
            Controls.Add(lblIcon);
            Controls.Add(dialogTitleBar1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(376, 180);
            MinimizeBox = false;
            MinimumSize = new Size(376, 180);
            Name = "dlgInput";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Load += dlgInput_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOk;
        private Controls.DialogTitleBar dialogTitleBar1;
        private TextBox txtInput;
        private Label lblIcon;
        private Label lblDescription;
    }
}