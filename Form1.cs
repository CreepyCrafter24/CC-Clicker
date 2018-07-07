using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClickTimer.Interval = 1000 / Int32.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickTimer.Start();
            button2.Enabled = true;
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickTimer.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClickTimer.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

         private void ClickTimer_Tick(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) != 0)
                {
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                switch (button3.Text)
                {
                    case "Left":
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                        break;
                    default:
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (button3.Text)
            {
                case "Left":
                    button3.Text = "Right";
                    break;
                default:
                    button3.Text = "Left";
                    break;
            }
        }
    }
}
