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

        /// <summary>
        /// Browse button handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e) {
            if (fbdDirectoryBrowse.ShowDialog() == DialogResult.OK) {
                txtWorkingDirectory.Text = fbdDirectoryBrowse.SelectedPath;
            } else {
                txtWorkingDirectory.Text = string.Empty;
            }

            List<String> files = DirSearch(txtWorkingDirectory.Text);
            lstDotfileCollection.DataSource = files;

            UpdateDotfileCount(files.Count);


        }

        /// <summary>
        /// Recursively checks a chosen directory for dotfiles.
        /// </summary>
        /// <param name="sDir"></param>
        /// <returns></returns>
        protected List<String> DirSearch(string sDir) {
            List<String> files = new List<String>();
            try {
                foreach (string f in Directory.GetFiles(sDir)) {
                    if (Path.GetFileName(f).Contains("._")) {
                        files.Add(f);
                    }
                }
                foreach (string d in Directory.GetDirectories(sDir)) {
                    files.AddRange(DirSearch(d));
                }
            } catch (System.Exception excpt) {
                MessageBox.Show(excpt.Message);
            }

            return files;
        }

        /// <summary>
        /// Updates the dot file counter on the main form.
        /// </summary>
        /// <param name="count"></param>
        protected void UpdateDotfileCount(int count) {
            lblDotfileCount.Text = string.Format("{0:n0}", count) + " Dotfle(s) selected";
        }
    }
}
