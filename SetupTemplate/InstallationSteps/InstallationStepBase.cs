using SetupTemplate.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupTemplate.InstallationSteps
{
    public abstract class InstallationStepBase
    {
        public abstract void Setup(Setup_UserControl setupUI);
        public virtual bool IsNeedToSetup
        {
            get
            {
                return true;
            }
        }

        public abstract int Order { get; }
    }
}
