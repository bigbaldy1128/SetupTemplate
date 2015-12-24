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
using NLog;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace SetupTemplate
{
    public static class SetupUtil
    {
        static Dictionary<string, Control> windows = new Dictionary<string, Control>();

        /// <summary>
        /// 安装信息
        /// </summary>
        /// <returns></returns>
        public static InstallInfo CurrentInstallInfo { get;set; }

        public static void Navigate(Type type)
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

        public static void RegInstallInfo()
        {
            var info= JsonConvert.SerializeObject(CurrentInstallInfo);
            Registry.LocalMachine
                .OpenSubKey("SOFTWARE", true)
                .CreateSubKey(StringConst.SetupPath)
                .SetValue("InstallInfo", info);
        }

        public static void InitInstallInfo()
        {
            try
            {
                var info = Registry.LocalMachine
                            .OpenSubKey("SOFTWARE", true)
                            .CreateSubKey(StringConst.SetupPath)
                            .GetValue("InstallInfo").ToString();
                CurrentInstallInfo = JsonConvert.DeserializeObject<InstallInfo>(info);
            }
            catch
            {
                CurrentInstallInfo = new InstallInfo();
            }
            finally
            {
                CurrentInstallInfo.Version = Application.ProductVersion;
            }
        }
    }
}
