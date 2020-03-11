using System;
using System.Drawing;
using System.Windows.Forms;
using CC_Functions.W32;
using CC_Functions.W32.Hooks;

namespace CC_Clicker_2._0
{
    public partial class MainForm : Form
    {
        private static bool _isSettingKey;
        private static Keys Key = Keys.LShiftKey;
        private static bool _isClicking;
        private static int _setDelay = 100;
        private static int _delmVal = 4;
        private readonly OvPForm _ov;
        private Point _loc = Point.Empty;

        public MainForm(KeyboardHook hook)
        {
            InitializeComponent();
            Button keyButton1 = keyButton;
            _ov = new OvPForm(_loc.X, _loc.Y);
            hook.OnKeyPress += (e) =>
            {
                if (_isSettingKey)
                {
                    Key = e.Key;
                    keyButton1.BackColor = Color.FromArgb(224, 224, 224);
                    clickBox.Enabled = true;
                    keyButton1.Text = Key.ToString();
                    _isSettingKey = false;
                }
                else
                {
                    if (e.Key == Key)
                        _isClicking = !_isClicking;
                }
            };
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
            if (!_isClicking) return;
            if (fixBox.Checked)
                Cursor.Position = _loc;
            Mouse.Click(rightBox.Checked);
            if (delmBox.Checked)
                timer.Interval = Math.Max(_setDelay + (new Random().Next(0, _delmVal) - (_delmVal / 2)), 1);
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            _ov.Hide();
            using LocForm frm = new LocForm();
            if (frm.ShowDialog() != DialogResult.OK) return;
            _loc = new Point(frm.X, frm.Y);
            fixBox.Checked = true;
            fixButton.BackColor = Color.Green;
            fixButton.Text = _loc.ToString();
        }

        private void fixBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_loc != Point.Empty) return;
            fixBox.Checked = false;
            fixButton.BackColor = Color.Red;
        }

        private void fixButton_MouseEnter(object sender, EventArgs e)
        {
            _ov.SetPos(_loc.X, _loc.Y);
            _ov.Show();
        }

        private void fixButton_MouseLeave(object sender, EventArgs e) => _ov.Hide();
    }
}