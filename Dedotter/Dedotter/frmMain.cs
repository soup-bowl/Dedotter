using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dedotter {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            if (fbdDirectoryBrowse.ShowDialog() == DialogResult.OK) {
                txtWorkingDirectory.Text = fbdDirectoryBrowse.SelectedPath;
            } else {
                txtWorkingDirectory.Text = string.Empty;
            }
        }
    }
}
