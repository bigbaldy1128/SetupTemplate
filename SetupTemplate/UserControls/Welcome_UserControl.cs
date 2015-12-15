﻿using System;
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
