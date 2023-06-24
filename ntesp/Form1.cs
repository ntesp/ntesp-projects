using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntesp {
    public partial class Form1 : Form {
        static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        static public string doing;
        static string AppName = string.Format("{0} - {1} v{2}.{3}.{4}.{5}",doing,assembly.GetName().FullName, assembly.GetName().Version.Major, assembly.GetName().Version.Minor, assembly.GetName().Version.Build, assembly.GetName().Version.Revision);
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = AppName;
        }

        private void MenuItemHelpAbout_Click(object sender, EventArgs e) {
            //var s = "";
            //s = string.Format(
            //    "{0} v{1} {2}\r\n",
            //    Application.ProductName,
            //    Application.ProductVersion,
            //    "(2023/06/23)"
            //);
            //System.Diagnostics.FileVersionInfo fileVersionInfo = (
            //    System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath));
            //var copyright = fileVersionInfo.LegalCopyright.ToString();
            //s += String.Format("{0}\r\n\r\n", copyright);
        }

        private void MenuItemHelpAboutVersion_Click(object sender, EventArgs e) {
            AboutVersion dialog = new AboutVersion();
            dialog.ShowDialog(this);
            dialog.Dispose();
        }

        private void MenuItemHelpViewReadme_Click(object sender, EventArgs e) {
            var s = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            s = System.IO.Path.Combine(s, "data","README.txt");
        }
    }
}
