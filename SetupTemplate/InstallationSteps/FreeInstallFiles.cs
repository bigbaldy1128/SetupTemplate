using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupTemplate.UserControls;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Reflection;

namespace SetupTemplate.InstallationSteps
{
    /// <summary>
    /// 释放安装文件
    /// </summary>
    public class FreeInstallFiles : InstallationStepBase
    {
        public override int Order
        {
            get
            {
                return 0;
            }
        }

        public void FreeFile()
        {
            var fileName = "package.zip";
            var tempPath = Path.GetTempPath();
            string _fileName = Path.Combine(tempPath, fileName);
            string _dir = Path.Combine(tempPath, Path.GetFileNameWithoutExtension(fileName));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SetupTemplate.InstallFiles." + fileName))
            {
                if (File.Exists(_fileName))
                {
                    File.Delete(_fileName);
                }
                if (Directory.Exists(_dir))
                {
                    Directory.Delete(_dir, true);
                }
                using (FileStream fs = new FileStream(_fileName, FileMode.CreateNew))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
            FastZip fz = new FastZip();
            try
            {
                fz.ExtractZip(_fileName, tempPath, "");
            }
            catch (Exception ex)
            {
                Log.Instance.Error(ex, "free install files({0}) failed", _fileName);
            }
        }

        public override void Setup(Setup_UserControl setupUI)
        {
            setupUI.SafeCall(() =>
            {
                setupUI.Label.Text = "释放安装文件";
            });
            FreeFile();
            setupUI.SafeCall(() =>
            {
                setupUI.ProgressBar.Value = 10;
            });
        }
    }
}
