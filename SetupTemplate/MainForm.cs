using SetupTemplate.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupTemplate
{
    public partial class MainForm : Form
    {
        public static ISetupUserControl CurrentControl { get; set; }
        public static Panel MainPanel { get; set; }
        public static Button ButtonCancel { get; set; }
        public static Button ButtonNext { get; set; }
        public static Button ButtonPrevious { get; set; }
        public static MainForm SetupMainForm { get;set; }

        /// <summary>
        /// 启用禁用关闭按钮
        /// </summary>
        /// <returns></returns>
        public static bool CloseButtonEnabled
        {
            set
            {
                if (!value)
                {
                    NativeAPI.EnableMenuItem(NativeAPI.GetSystemMenu(SetupMainForm.Handle, false), 
                                             NativeAPI.SC_CLOSE, 
                                             NativeAPI.MF_BYCOMMAND | NativeAPI.MF_GTAYED | NativeAPI.MF_DISABLED);
                }
                else
                {
                    NativeAPI.EnableMenuItem(NativeAPI.GetSystemMenu(SetupMainForm.Handle, false), 
                                             NativeAPI.SC_CLOSE, 
                                             NativeAPI.MF_BYCOMMAND);
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            MainPanel = main_Panel;
            ButtonCancel = button3;
            ButtonNext = button2;
            ButtonPrevious = button1;
            SetupMainForm = this;
            this.Text = StringConst.SetupTitle;
            Util.Navigate(typeof(Welcome_UserControl));
        }

        private void button1_Click(object sender, EventArgs e) //上一步
        {
            CurrentControl.Previous();
        }

        private void button2_Click(object sender, EventArgs e) //下一步
        {
            CurrentControl.Next();
        }

        private void button3_Click(object sender, EventArgs e) //取消
        {
            if (MessageBox.Show("您确定要退出安装？", "退出安装", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Util.Exit();
            }
        }
    }
}
