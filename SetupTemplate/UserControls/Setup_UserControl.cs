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

namespace SetupTemplate.UserControls
{
    public partial class Setup_UserControl : UserControl,ISetupUserControl
    {
        public RichTextBox RichTextBox;
        public ProgressBar ProgressBar;

        public Setup_UserControl()
        {
            InitializeComponent();
        }

        public void Previous()
        {
            SetupUtil.GoTo(typeof(Welcome_UserControl));
        }

        public void Next() //安装
        {
            foreach (var step in System.Reflection.Assembly
                                 .GetExecutingAssembly()
                                 .GetImplementedObjectsByInterface<IInstallationStep>()
                                 .OrderBy(t=>t.Order))
            {
                step.Setup(this);
            }
        }

        public void InitUI()
        {
            MainForm.ButtonPrevious.Enabled = true;
            MainForm.ButtonNext.Enabled = true;
            MainForm.ButtonNext.Text = "安装";
            MainForm.ButtonCancel.Enabled = true;
        }
    }
}
