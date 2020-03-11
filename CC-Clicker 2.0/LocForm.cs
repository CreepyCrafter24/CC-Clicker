using System;
using System.Windows.Forms;
using CC_Functions.W32;

namespace CC_Clicker_2._0
{
    public partial class LocForm : Form
    {
        private bool _close;
        public int X;
        public int Y;
        public LocForm() => InitializeComponent();
        private void LocForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !_close;

        private void LocForm_MouseClick(object sender, MouseEventArgs e)
        {
            X = Cursor.Position.X;
            Y = Cursor.Position.Y;
            _close = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LocForm_Load(object sender, EventArgs e) => this.GetWnd32().Overlay = true;
    }
}