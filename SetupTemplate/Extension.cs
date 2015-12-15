using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupTemplate
{
    public static class Extension
    {
        public static void SafeCall(this Control ctrl, Action callback)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(callback);
            }
            else
            {
                callback();
            }
        }
    }
}
