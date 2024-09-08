namespace Pepris.Controls {
    public partial class DialogTitleBar : UserControl {
        private string _title;
        private bool _canMove = true;
        private bool _canAutoClose = false;
        private bool _mouseDown;
        private Point _lastLocation;
        WindowsSymbols symbols = new();

        public DialogTitleBar() {
            InitializeComponent();
            symbols.ApplySymbol("back", btnClose);
        }

        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                lblTitle.Text = _title;
            }
        }
        public bool CanAutoClose {
            get {
                return _canAutoClose;
            }
            set {
                _canAutoClose = value;
            }
        }
        public bool CanMove {
            get {
                return _canMove;
            }
            set {
                _canMove = value;
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e) {
            if (_canMove && e.Button == MouseButtons.Left) {
                _mouseDown = true;
                _lastLocation = e.Location;
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e) {
            if (_canMove && _mouseDown) {
                var parentForm = this.Parent;
                if (parentForm != null) {
                    parentForm.Location = new Point(
                        (parentForm.Location.X - _lastLocation.X) + e.X,
                        (parentForm.Location.Y - _lastLocation.Y) + e.Y
                    );
                    parentForm.Update();
                }
            }
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e) {
            _mouseDown = false;
        }
        public event EventHandler CloseCall;
        private void btnClose_Click(object sender, EventArgs e) {
            CloseCall?.Invoke(this, EventArgs.Empty);

            var parentForm = this.FindForm();
            if (parentForm != null) {
                parentForm.Close();
            }
        }

        private void DialogTitleBar_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape && _canAutoClose) {
                var parentForm = this.FindForm();
                if (parentForm != null) {
                    parentForm.Close();
                }
            }
        }
    }
}
