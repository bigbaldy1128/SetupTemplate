using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupTemplate.UserControls;

namespace SetupTemplate.InstallationSteps
{
    /// <summary>
    /// 释放安装文件
    /// </summary>
    public class FreeInstallFiles : IInstallationStep
    {
        public int Order
        {
            get
            {
                return 0;
            }
        }

        public void Setup(Setup_UserControl setupUI)
        {
            setupUI.SafeCall(() =>
            {
                setupUI.Label.Text = "释放安装文件";
            });
            Util.FreeFile();
            setupUI.SafeCall(() =>
            {
                setupUI.ProgressBar.Value = 10;
            });
        }
    }
}
