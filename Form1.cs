using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

#pragma warning disable IDE1006
namespace CC_Clicker_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SessionData.keyButton = keyButton;
        }

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (SessionData.isSettingKey)
                {
                    SessionData.key = (Keys)vkCode;
                    SessionData.keyButton.BackColor = Color.FromArgb(224, 224, 224);
                    SessionData.keyButton.Text = ((Keys)vkCode).ToString();
                    SessionData.isSettingKey = false;
                }
                else
                {
                    if ((Keys)vkCode == SessionData.key)
                        SessionData.isClicking = !SessionData.isClicking;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private void clickBox_CheckedChanged(object sender, EventArgs e)
        {
            SessionData.isClicking = false;
            timer1.Enabled = clickBox.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(timeBox.Text, out int re) && re > 0)
            {
                SessionData.setDelay = re;
                timer1.Interval = re;
                timeBox.BackColor = Color.White;
            } else
            {
                timeBox.BackColor = Color.Red;
            }
        }

        private void delmVal_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(delmVal.Text, out int re) && re > 0 && re % 2 == 0)
            {
                SessionData.delmVal = re;
                delmVal.BackColor = Color.White;
            }
            else
            {
                delmVal.BackColor = Color.Red;
            }
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            SessionData.isSettingKey = true;
            keyButton.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SessionData.isClicking) {
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                if (rightBox.Checked)
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                else
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                if (DelmBox.Checked)
                    timer1.Interval = Math.Max(SessionData.setDelay + (new Random().Next(0, SessionData.delmVal) - (SessionData.delmVal / 2)), 1);
            }
        }

        private void Form1_Resize(object sender, EventArgs e) => WindowState = FormWindowState.Normal;

        #region DllImports and dummy code
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        public static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        public static LowLevelKeyboardProc _proc = HookCallback;
        public static IntPtr _hookID = IntPtr.Zero;
        public static class SessionData
        {
            public static Button keyButton;
            public static bool isSettingKey = false;
            public static Keys key = Keys.LShiftKey;
            public static bool isClicking = false;
            public static int setDelay = 100;
            public static int delmVal = 4;
        }
        #endregion

    }
}
