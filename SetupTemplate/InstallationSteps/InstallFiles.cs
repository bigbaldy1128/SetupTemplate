using System;
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
            Thread.Sleep(2000);
            setupUI.SafeCall(() => { setupUI.ProgressBar.Value = 25; });
            Thread.Sleep(2000);
            setupUI.SafeCall(() => { setupUI.ProgressBar.Value = 50; });
            Thread.Sleep(2000);
            setupUI.SafeCall(() => { setupUI.ProgressBar.Value = 75; });
            Thread.Sleep(2000);
            setupUI.SafeCall(() => { setupUI.ProgressBar.Value = 100; });
        }
    }
}
