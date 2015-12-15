using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate
{
    public class win32Apics
    {
        const uint SC_CLOSE = 0xf060;
        const uint MF_BYCOMMAND = 0x0;
        const uint MF_GTAYED = 0x1;
        const uint MF_DISABLED = 0x2;

        [DllImport("user32.dll")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);
    }
}
