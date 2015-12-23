using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SetupTemplate.InstallationSteps;
using System.Threading;

namespace SetupTemplate.UserControls
{
    public partial class Setup_UserControl : UserControl,ISetupUserControl
    {
        public Label Label;
        public ProgressBar ProgressBar;

        public Setup_UserControl()
        {
            InitializeComponent();
            Label = this.label2;
            ProgressBar = this.progressBar1;
            label1.Text = string.Format("请等待“{0}”的安装完成", StringConst.ProductName);
        }

        public void Previous()
        {
            Util.Navigate(typeof(Welcome_UserControl));
        }

        public void Next() //下一步
        {
            Util.Navigate(typeof(SetupFinished_UserControl));
        }

        public void Install()
        {
            foreach (var step in System.Reflection.Assembly
                                 .GetExecutingAssembly()
                                 .GetImplementedObjectsByInterface<IInstallationStep>()
                                 .OrderBy(t => t.Order))
            {
                step.Setup(this);
            }
            this.SafeCall(() =>
            {
                MainForm.ButtonNext.Enabled = true;
                MainForm.CloseButtonEnabled = true;
            });
        }

        public void InitUI()
        {
            MainForm.ButtonPrevious.Enabled = false;
            MainForm.ButtonNext.Enabled = false;
            MainForm.ButtonNext.Text = "下一步 >";
            MainForm.ButtonCancel.Enabled = false;
            MainForm.CloseButtonEnabled = false;
            new Thread(() =>
            {
                Install();
            }).Start();
        }
    }
}
