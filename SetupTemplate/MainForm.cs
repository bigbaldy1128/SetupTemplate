using SetupTemplate.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public MainForm()
        {
            InitializeComponent();
            MainPanel = main_Panel;
            ButtonCancel = button3;
            ButtonNext = button2;
            ButtonPrevious = button1;
            this.Text = StringConst.SetupTitle;
        }
    }
}
