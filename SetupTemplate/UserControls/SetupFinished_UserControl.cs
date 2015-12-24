using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SetupTemplate.UserControls
{
    public partial class SetupFinished_UserControl : UserControl, ISetupUserControl
    {
        public SetupFinished_UserControl()
        {
            InitializeComponent();
            label2.Text = string.Format("完成“{0}”安装向导", StringConst.ProductName);
            label1.Text = string.Format(@"“{0}”的安装已完成。

单击[完成] 关闭向导。", StringConst.ProductName);
        }

        public void Next()
        {
            Application.Exit();
        }

        public void Previous()
        {
            throw new NotImplementedException();
        }

        public void InitUI()
        {
            MainForm.ButtonPrevious.Enabled = false;
            MainForm.ButtonNext.Enabled = true;
            MainForm.ButtonNext.Text = "完成";
            MainForm.ButtonCancel.Enabled = false;
            MainForm.CloseButtonEnabled = true;
        }
    }
}
