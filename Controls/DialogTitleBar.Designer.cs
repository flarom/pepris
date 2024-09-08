namespace Pepris.Controls {
    partial class DialogTitleBar {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            btnClose = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Left;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 75, 75);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 0, 0, 6);
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Text = "<";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 9F);
            lblTitle.Location = new Point(30, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(3, 0, 0, 6);
            lblTitle.Size = new Size(228, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Dialog";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.MouseDown += lblTitle_MouseDown;
            lblTitle.MouseMove += lblTitle_MouseMove;
            lblTitle.MouseUp += lblTitle_MouseUp;
            // 
            // DialogTitleBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            ForeColor = Color.White;
            Name = "DialogTitleBar";
            Size = new Size(258, 30);
            KeyDown += DialogTitleBar_KeyDown;
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        public Button btnClose;
    }
}
