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
using static System.Windows.Forms.ListView;

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

            lstDotfiles.Items.Clear();
            List<ListViewItem> lvi = ListViewConverter(DirSearch(txtWorkingDirectory.Text));
            foreach (ListViewItem listview in lvi) {
                lstDotfiles.Items.Add(listview);
            }

            UpdateDotfileCount(files.Count);


        }

        private void btnSelectAll_Click(object sender, EventArgs e) {
            List<ListViewItem> listItems = modifySelectionStatus(lstDotfiles.Items, true);
            lstDotfiles.Clear();
            foreach (ListViewItem lvi in listItems) {
                lstDotfiles.Items.Add(lvi);
            }  
        }

        private void btnDeselectAll_Click(object sender, EventArgs e) {
            List<ListViewItem> listItems = modifySelectionStatus(lstDotfiles.Items, false);
            lstDotfiles.Clear();
            foreach (ListViewItem lvi in listItems) {
                lstDotfiles.Items.Add(lvi);
            }
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

        /// <summary>
        /// Converts a string collection into a list view compatible item.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        protected List<ListViewItem> ListViewConverter(List<string> list) {
            List<ListViewItem> entryList = new List<ListViewItem>();
            foreach (string entry in list) {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = entry;
                lstDotfiles.Items.Add(viewItem);
            }

            return entryList;
        }

        /// <summary>
        /// Changes whether each item is checked or unchecked.
        /// </summary>
        /// <param name="currentList"></param>
        /// <param name="checkedState"></param>
        /// <returns></returns>
        protected List<ListViewItem> modifySelectionStatus(ListViewItemCollection currentList, Boolean checkedState) {
            List<ListViewItem> lvi = new List<ListViewItem>();
            foreach (ListViewItem item in currentList) {
                item.Checked = checkedState;
                lvi.Add(item);
            }

            return lvi;
        }

    }
}
