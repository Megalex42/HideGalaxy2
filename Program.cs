using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HideGalaxy2
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);
        private enum WindowShowStyle : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        }
        static void Main(string[] args)
        {
            Process[] p = Process.GetProcessesByName("GalaxyClient");
            if (p.Length > 0)
            {
                IntPtr hWnd = p[0].MainWindowHandle;

                ShowWindow(hWnd, WindowShowStyle.Hide);
            }
        }
    }
}
