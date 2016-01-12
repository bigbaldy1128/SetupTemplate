using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate
{
    [Serializable]
    public class InstallInfo
    {
        /// <summary>
        /// 版本号
        /// </summary>
        /// <returns></returns>
        public string Version { get;set; }
        /// <summary>
        /// 安装路径
        /// </summary>
        /// <returns></returns>
        public string InstallationPath { get;set; }
    }
}
