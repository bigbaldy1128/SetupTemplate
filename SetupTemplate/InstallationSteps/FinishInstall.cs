using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupTemplate.UserControls;
using System.Threading;
using System.IO;

namespace SetupTemplate.InstallationSteps
{
    /// <summary>
    /// 完成安装
    /// </summary>
    public class FinishInstall : InstallationStepBase
    {
        public override int Order
        {
            get
            {
                return 100;
            }
        }

        void ClearInstallFiles()
        {
            var tempPath = Path.GetTempPath();
            string packageZip = Path.Combine(tempPath, "package.zip");
            string packageDir = Path.Combine(tempPath, "package");
            if (File.Exists(packageZip))
            {
                File.Delete(packageZip);
            }
            if (Directory.Exists(packageDir))
            {
                Directory.Delete(packageDir, true);
            }
        }

        public override void Setup(Setup_UserControl setupUI)
        {
            setupUI.SafeCall(() =>
            {
                setupUI.Label.Text = "正在完成安装";
                setupUI.ProgressBar.Value = 99;
            });

            ClearInstallFiles();
            Thread.Sleep(50);
            SetupUtil.RegInstallInfo();

            setupUI.SafeCall(() =>
            {
                setupUI.ProgressBar.Value = 100;
                setupUI.Label.Text = "安装成功！";
            });
        }
    }
}
