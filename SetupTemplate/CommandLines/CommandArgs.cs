using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate.CommandLines
{
    public class CommandArgs
    {
        private Dictionary<string, string> mArgPairs = new Dictionary<string, string>();

        public Dictionary<string, string> ArgPairs
        {
            get { return mArgPairs; }
        }

        private List<string> mParams = new List<string>();
        public List<string> Params
        {
            get { return mParams; }
        }
    }
}
