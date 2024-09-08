namespace Pepris {
    public partial class dlgSelect : Form {
        private string[] _options;
        private string[] _optionIcons;
        private string _title;
        private int _optionSelected;
        WindowsSymbols symbols = new();
        public dlgSelect() {
            InitializeComponent();
            symbols.ApplySymbol("check", btnOk);
            this.CancelButton = dialogTitleBar1.btnClose;
        }

        public int getAnswer(string[] options, string[] optionIcons, string title = "Select") {
            _options = options;
            _optionIcons = optionIcons;
            _title = title;

            if (ShowDialog() == DialogResult.OK) {
                return _optionSelected;
            }
            else {
                return 0;
            }
        }

        private void dlgSelect_Load(object sender, EventArgs e) {
            flpOptions.Controls.Clear();
            dialogTitleBar1.Title = this._title;

            WindowEffects.useDarkBorder(this.Handle, true);

            int index = 0;
            foreach (string option in _options) {
                Button btnOption = new Button();

                btnOption.Text = option;
                btnOption.Tag = index;
                btnOption.TabIndex = index;
                btnOption.TextAlign = ContentAlignment.MiddleLeft;
                btnOption.ImageAlign = ContentAlignment.MiddleLeft;
                btnOption.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnOption.Image = symbols.GetSymbolAsImage(_optionIcons[index], Color.White, 18);
                btnOption.Size = new Size(250, 35);
                btnOption.Dock = DockStyle.Top;
                btnOption.FlatStyle = FlatStyle.Flat;
                btnOption.FlatAppearance.BorderSize = 0;
                btnOption.Cursor = Cursors.Hand;

                btnOption.Click += BtnOption_Click;
                btnOption.Enter += ButtonFocused;

                flpOptions.Controls.Add(btnOption);

                index++;
            }
            btnOk.TabIndex = index + 1;
            dialogTitleBar1.TabIndex = index + 2;
            flpOptions.Controls[0].Select();
        }


        private void BtnOption_Click(object? sender, EventArgs e) {
            Button btnOption = (Button)sender;

            _optionSelected = int.Parse(btnOption.Tag.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
        private async void ButtonFocused(object? sender, EventArgs e) {
            foreach (Control con in flpOptions.Controls) {
                if (con is Button unfocused) {
                    unfocused.BackColor = Color.FromArgb(40, 40, 40);
                    unfocused.Padding = new Padding(0, 0, 0, 0);
                }
            }
            if (sender is Button focused) {
                focused.BackColor = Color.FromArgb(60,60,60);
                for (int i = 0; i <= 20; i += 2) {
                    focused.Padding = new Padding(i, 0, 0, 0);
                    await Task.Delay(1);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dialogTitleBar1_CloseCall(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
