using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate
{
    public class NativeAPI
    {
        public const uint SC_CLOSE = 0xf060;
        public const uint MF_BYCOMMAND = 0x0;
        public const uint MF_GTAYED = 0x1;
        public const uint MF_DISABLED = 0x2;

        [DllImport("user32.dll")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        public static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem,uint uEnable);
    }
}
