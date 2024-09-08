namespace Pepris {
    public partial class dlgInput : Form {
        private string _title;
        private string _description;
        private string _defaultText;
        private bool _showText;
        private string _icon;
        WindowsSymbols symbols = new();
        public dlgInput() {
            InitializeComponent();
            this.CancelButton = dialogTitleBar1.btnClose;
        }

        public string getInput(string title, string description, string defaultText, bool showText = true, string icon = "\ue104") {
            _title = title;
            _description = description;
            _defaultText = defaultText;
            _showText = showText;
            _icon = icon;

            return ShowDialog() == DialogResult.OK ? txtInput.Text : string.Empty;
        }

        private void dlgInput_Load(object sender, EventArgs e) {
            WindowEffects.useDarkBorder(this.Handle, true);

            dialogTitleBar1.Title = _title;
            lblDescription.Text = _description;
            symbols.ApplySymbol(_icon, lblIcon, 28);
            txtInput.UseSystemPasswordChar = !_showText;
            if (_defaultText != string.Empty) {
                txtInput.Text = _defaultText;
            }
            else {
                txtInput.Text = string.Empty;
            }

            txtInput.SelectAll();
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
