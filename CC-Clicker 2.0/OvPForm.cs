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
    public partial class OvPForm : Form
    {
        public OvPForm(int x, int y)
        {
            InitializeComponent();
            setPos(x, y);
        }
        public void setPos(int x, int y) => Location = new Point(x - (Width / 2), y - (Height / 2));

        private void OvPForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), (Width / 2) - 15, Height / 2, (Width / 2) + 15, Height / 2);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), Width / 2, (Height / 2) - 15, Width / 2, (Height / 2) + 15);
        }

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOMOVE = 0x0002;
        const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private void OvPForm_Load(object sender, EventArgs e) => SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
    }
}
