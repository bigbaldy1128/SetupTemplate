using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate.InstallationSteps
{
    public class InstallationStepAttribute :Attribute
    {
        public int Order { get;set; }
        public InstallationStepAttribute(int order)
        {
            this.Order = order;
        }
    }
}
