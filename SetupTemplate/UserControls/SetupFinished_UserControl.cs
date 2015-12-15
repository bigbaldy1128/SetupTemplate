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
        }

        public void Next()
        {
            Util.Exit();
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
