using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;

#pragma warning disable IDE1006
namespace CC_Clicker_2._0
{
    public partial class MainForm : Form
    {
        Point loc = Point.Empty;
        OvPForm ov;
        public static Button _keyButton;
        public static bool _isSettingKey = false;
        public static Keys _key = Keys.LShiftKey;
        public static bool _isClicking = false;
        public static int _setDelay = 100;
        public static int _delmVal = 4;
        public static CheckBox _clickBox;
        public MainForm()
        {
            InitializeComponent();
            _keyButton = keyButton;
            _clickBox = clickBox;
            ov = new OvPForm(loc.X, loc.Y);
        }

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (_isSettingKey)
                {
                    _key = (Keys)vkCode;
                    _keyButton.BackColor = Color.FromArgb(224, 224, 224);
                    _clickBox.Enabled = true;
                    _keyButton.Text = ((Keys)vkCode).ToString();
                    _isSettingKey = false;
                }
                else
                {
                    if ((Keys)vkCode == _key)
                        _isClicking = !_isClicking;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private void clickBox_CheckedChanged(object sender, EventArgs e)
        {
            _isClicking = false;
            timer.Enabled = clickBox.Checked;
        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(timeBox.Text, out int re) && re > 0)
            {
                _setDelay = re;
                timer.Interval = re;
                timeBox.BackColor = Color.White;
            }
            else
            {
                timeBox.BackColor = Color.Red;
            }
        }

        private void delmVal_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(delmVal.Text, out int re) && re > 0 && re % 2 == 0)
            {
                _delmVal = re;
                delmVal.BackColor = Color.White;
            }
            else
            {
                delmVal.BackColor = Color.Red;
            }
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            _isSettingKey = true;
            keyButton.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_isClicking)
            {
                if (fixBox.Checked)
                    Cursor.Position = loc;
                mouse_event((uint)(rightBox.Checked ? (MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP) : (MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP)), (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                if (delmBox.Checked)
                    timer.Interval = Math.Max(_setDelay + (new Random().Next(0, _delmVal) - (_delmVal / 2)), 1);
            }
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            ov.Hide();
            LocForm frm = new LocForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loc = new Point(frm.X, frm.Y);
                fixBox.Checked = true;
                fixButton.BackColor = Color.Green;
                fixButton.Text = loc.ToString();
            }
        }

        private void fixBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loc == Point.Empty)
            {
                fixBox.Checked = false;
                fixButton.BackColor = Color.Red;
            }
        }

        private void fixButton_MouseEnter(object sender, EventArgs e)
        {
            ov.setPos(loc.X, loc.Y);
            ov.Show();
        }

        private void fixButton_MouseLeave(object sender, EventArgs e) => ov.Hide();
        #region DllImports
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);
        public static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x0100;
        public static LowLevelKeyboardProc _proc = HookCallback;
        public static IntPtr _hookID = IntPtr.Zero;
        #endregion
    }
}
