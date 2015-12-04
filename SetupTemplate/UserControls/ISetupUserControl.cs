using SetupTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetupTemplate.UserControls
{
    public interface ISetupUserControl
    {
        void Next();
        void Previous();
        void InitUI();
    }
}
