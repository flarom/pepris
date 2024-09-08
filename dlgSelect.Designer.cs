namespace Pepris {
    partial class dlgSelect {
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
            panel1 = new Panel();
            btnOk = new Button();
            flpOptions = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dialogTitleBar1.Size = new Size(293, 30);
            dialogTitleBar1.TabIndex = 1;
            dialogTitleBar1.Title = "Select";
            dialogTitleBar1.CloseCall += dialogTitleBar1_CloseCall;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOk);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 32);
            panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Dock = DockStyle.Right;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe Fluent Icons", 12F);
            btnOk.Location = new Point(261, 0);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(32, 32);
            btnOk.TabIndex = 0;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // flpOptions
            // 
            flpOptions.AutoScroll = true;
            flpOptions.BackColor = Color.FromArgb(40, 40, 40);
            flpOptions.Dock = DockStyle.Fill;
            flpOptions.Location = new Point(0, 30);
            flpOptions.Name = "flpOptions";
            flpOptions.Size = new Size(293, 292);
            flpOptions.TabIndex = 2;
            // 
            // dlgSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(293, 354);
            ControlBox = false;
            Controls.Add(flpOptions);
            Controls.Add(panel1);
            Controls.Add(dialogTitleBar1);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(309, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(309, 370);
            Name = "dlgSelect";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += dlgSelect_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.DialogTitleBar dialogTitleBar1;
        private Panel panel1;
        private Button btnOk;
        private FlowLayoutPanel flpOptions;
    }
}