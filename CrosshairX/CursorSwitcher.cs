using System;
using System.Runtime.InteropServices;

namespace CrosshairX
{
    public static class CursorSwitcher
    {
        [DllImport("user32.dll")]
        private static extern int SetCursor(IntPtr hCursor);

        [DllImport("user32.dll")]
        private static extern IntPtr LoadCursorFromFile(string lpFileName);

        public static void Set()
        {
            var cursorPath = "D:\\Програмування\\vs2022 repos\\CrosshairX\\CrosshairX\\Assets\\CustomCursor.cur";
            var hCursor = LoadCursorFromFile(cursorPath);
            SetCursor(hCursor);
        }

        public static void Return()
        {
            SetCursor(IntPtr.Zero);
        }
    }
}
