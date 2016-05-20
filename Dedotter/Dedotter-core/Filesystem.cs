using Dedotter_core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedotter_core {
    public class Filesystem {
        /// <summary>
        /// Builds up a collection of accessible directories.
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static List<Dotfiles> DirectorySearch(string sDir) {
            // Credit goes to this SO answer http://stackoverflow.com/a/14305616
            List<Dotfiles> files = new List<Dotfiles>();
            try {
                // Add each matched file in the current directory.
                foreach (string f in Directory.GetFiles(sDir)) {
                    // Check for dotfiles (they have ._ at the beginning of them).
                    if (Path.GetFileName(f).Contains("._")) {
                        Dotfiles lstObject = new Dotfiles();
                        lstObject.Name = Path.GetFileName(f);
                        lstObject.Path = f;
                        lstObject.VisibleFlag = File.GetAttributes(f).HasFlag(FileAttributes.Hidden);
                        files.Add(lstObject);
                    }
                }
                // Run this method within itself to add files from subdirectories.
                foreach (string d in Directory.GetDirectories(sDir)) {
                    files.AddRange(DirectorySearch(d));
                }
            } catch (System.Exception excpt) {
                //MessageBox.Show(excpt.Message);
            }

            return files;
        }
    }
}
