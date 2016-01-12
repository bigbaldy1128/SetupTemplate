using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate
{
    public class Log
    {
        public static ILogger Instance = LogManager.GetCurrentClassLogger();

        static Log()
        {
            var config = new LoggingConfiguration();
            var fileTarget = new FileTarget()
            {
                Layout = "${longdate} ${uppercase:[${level}]} - ${message} ${exception:format=tostring}",
                FileName = "${basedir}/logs/${shortdate}.log",
                Encoding = Encoding.UTF8
            };
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, fileTarget));
            LogManager.Configuration = config;
        }
    }
}
