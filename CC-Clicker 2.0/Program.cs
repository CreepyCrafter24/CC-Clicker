using System;
using System.Windows.Forms;
using CC_Functions.W32.Hooks;

namespace CC_Clicker_2._0
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            using KeyboardHook hook = new KeyboardHook();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(hook));
        }
    }
}