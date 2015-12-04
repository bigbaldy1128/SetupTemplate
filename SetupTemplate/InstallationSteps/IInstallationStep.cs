using SetupTemplate.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupTemplate.InstallationSteps
{
    public interface IInstallationStep
    {
        void Setup(Setup_UserControl setupUI);
        int Order { get; }
    }
}
