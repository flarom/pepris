using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Pepris.Controls {
    [DefaultEvent("SelectedKeyChanged")]
    public partial class KeyBox : UserControl {
        private Keys selectedKey = Keys.None;

        public event EventHandler SelectedKeyChanged;

        public KeyBox() {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
            this.Text = "None";
        }

        public Keys SelectedKey {
            get {
                return selectedKey;
            }
            set {
                if (selectedKey != value) {
                    selectedKey = value;
                    this.Text = selectedKey == Keys.None ? "None" : selectedKey.ToString();
                    this.Invalidate();

                    OnSelectedKeyChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnSelectedKeyChanged(EventArgs e) {
            SelectedKeyChanged?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnEnter(EventArgs e) {
            base.OnEnter(e);
            this.BackColor = SystemColors.Highlight;
            this.ForeColor = SystemColors.HighlightText;
        }

        protected override void OnLeave(EventArgs e) {
            base.OnLeave(e);
            this.BackColor = this.Parent.BackColor;
            this.ForeColor = this.Parent.ForeColor;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            this.SelectedKey = keyData;
            return true;
        }

        public void clearKey() {
            selectedKey = Keys.None;
            Text = "None";
        }
    }
}
