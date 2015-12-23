using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetupTemplate.UserControls
{
    public partial class Welcome_UserControl : UserControl,ISetupUserControl
    {
        public Welcome_UserControl()
        {
            InitializeComponent();
            label2.Text = string.Format("欢迎使用“{0}”安装向导", StringConst.ProductName);
            label1.Text = string.Format(@"这个向导将指引你完成“{0}”的安装进程。

单击[下一步] 继续。", StringConst.ProductName);
        }

        public void Next()
        {
            Util.Navigate(typeof(InstallPath_UserControl));
        }

        public void Previous()
        {
            
        }

        public void InitUI()
        {
            MainForm.ButtonPrevious.Enabled = false;
            MainForm.ButtonNext.Enabled = true;
            MainForm.ButtonCancel.Enabled = true;
            MainForm.ButtonNext.Text = "下一步 >";
        }
    }
}
