using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using SetupTemplate;
using SetupTemplate.UserControls;

namespace SetupTemplate
{
    public static class SetupUtil
    {
        static Dictionary<string, Control> windows = new Dictionary<string, Control>();

        public static void GoTo(Type type)
        {
            MainForm.MainPanel.Controls.Clear();
            if (windows.Keys.Contains(type.FullName))
            {
                MainForm.MainPanel.Controls.Add(windows[type.FullName]);
                MainForm.CurrentControl = windows[type.FullName] as ISetupUserControl;
            }
            else
            {
                Control window = type.Assembly.CreateInstance(type.FullName) as Control;
                MainForm.MainPanel.Controls.Add(window);
                windows.Add(type.FullName, window);
                MainForm.CurrentControl = window as ISetupUserControl;
            }
            MainForm.CurrentControl.InitUI();
        }
    }
}
