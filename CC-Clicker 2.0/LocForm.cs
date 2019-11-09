using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Clicker_2._0
{
    public partial class LocForm : Form
    {
        public int X;
        public int Y;
        public LocForm() => InitializeComponent();
        bool close;
        private void LocForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = !close;

        private void LocForm_MouseClick(object sender, MouseEventArgs e)
        {
            X = Cursor.Position.X;
            Y = Cursor.Position.Y;
            close = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOMOVE = 0x0002;
        const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private void LocForm_Load(object sender, EventArgs e) => SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
    }
}
