using System;
using System.Drawing;
using System.Windows.Forms;
using CC_Functions.W32;

namespace CC_Clicker_2._0
{
    public partial class OvPForm : Form
    {
        public OvPForm(int x, int y)
        {
            InitializeComponent();
            SetPos(x, y);
        }

        public void SetPos(int x, int y) => Location = new Point(x - (Width / 2), y - (Height / 2));

        private void OvPForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), (Width / 2) - 15, Height / 2, (Width / 2) + 15, Height / 2);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), Width / 2, (Height / 2) - 15, Width / 2, (Height / 2) + 15);
        }

        private void OvPForm_Load(object sender, EventArgs e) => this.GetWnd32().Overlay = true;
    }
}