using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntesp {
    public partial class AboutVersion : Form {
        public AboutVersion() {
            InitializeComponent();
        }

        private void AboutVersion_Load(object sender, EventArgs e) {
            this.label1.Text = string.Format("{0} v{1} {2}\r\n{3}",Application.ProductName,Application.ProductVersion,"",System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath).LegalCopyright);
        }
    }
}
