using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SetupTemplate.UserControls
{
    public partial class InstallPath_UserControl : UserControl,ISetupUserControl
    {
        public InstallPath_UserControl()
        {
            InitializeComponent();
        }

        string GetNeedSpace()
        {
            string dir = Path.Combine(Path.GetTempPath(), "CodeSecurity");
            if (!Directory.Exists(dir))
            {
                return "0MB";
            }
            long dirSize = 0;
            string[] fs = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            foreach (string f in fs)
            {
                FileInfo fi = new FileInfo(f);
                dirSize += fi.Length;
            }
            return Math.Round(dirSize / 1024 / 1024.0, 1) + "MB";
        }

        string GetDriveFreeSpace(string drive_name)
        {
            foreach (var v in DriveInfo.GetDrives())
            {
                if (v.Name.StartsWith(drive_name))
                {
                    return Math.Round(v.AvailableFreeSpace / 1024 / 1024 / 1024.0, 1) + "GB";
                }
            }
            return "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                installPath_textBox.Text =Path.Combine(folderBrowserDialog1.SelectedPath, StringConst.SetupPath);
            }
        }

        public void Previous()
        {
            SetupUtil.GoTo(typeof(Welcome_UserControl));
        }

        public void Next()
        {
            
        }

        private void installPath_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(installPath_textBox.Text))
                {
                    Directory.CreateDirectory(installPath_textBox.Text);
                    Directory.Delete(installPath_textBox.Text);
                }
                
                MainForm.ButtonNext.Enabled = true;
                hdFreeSpace_label.Visible = true;
                label5.Visible = true;
                hdFreeSpace_label.Text = GetDriveFreeSpace(installPath_textBox.Text[0].ToString().ToUpper());
            }
            catch
            {
                MainForm.ButtonNext.Enabled = false;
                hdFreeSpace_label.Visible = false;
                label5.Visible = false;
            }
        }

        public void InitUI()
        {
            MainForm.ButtonPrevious.Enabled = true;
            MainForm.ButtonNext.Enabled = true;
            MainForm.ButtonNext.Text = "安装";
            MainForm.ButtonCancel.Enabled = true;
            needSpace_label.Text = GetNeedSpace();
            hdFreeSpace_label.Text = GetDriveFreeSpace(installPath_textBox.Text[0].ToString());
        }
    }
}
