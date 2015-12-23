﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupTemplate.UserControls;
using System.Threading;

namespace SetupTemplate.InstallationSteps
{
    public class InstallFiles : IInstallationStep
    {
        public int Order
        {
            get
            {
                return 1;
            }
        }

        public void Setup(Setup_UserControl setupUI)
        {
            setupUI.SafeCall(() => {
                setupUI.Label.Text = "拷贝安装文件";
            });

            //todo

            setupUI.SafeCall(() =>
            {
                setupUI.ProgressBar.Value = 90;
            });
        }
    }
}
