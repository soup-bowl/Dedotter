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
        public static List<Dotfiles> DirectorySearch(string sDir, bool logging = false) {
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
                if(logging == true) {
                    CacheWriter("An error occured: " + excpt.Message);
                }
            }

            return files;
        }


        /// <summary>
        /// Writes to the dedotter log.
        /// </summary>
        /// <param name="message"></param>
        public static void CacheWriter(string message) {
            string logfile = Path.Combine(Path.GetTempPath(), "dedotter-dir.log");
            using (StreamWriter writelog = new StreamWriter(logfile)) {
                writelog.WriteLine(message);
            }
        }

        /// <summary>
        /// Deletes the log file.
        /// </summary>
        public static void CacheDelete() {
            if (Filesystem.CacheExists()) {
                File.Delete(Path.Combine(Path.GetTempPath(), "dedotter-dir.log"));
            }
        }

        /// <summary>
        /// Counts the errors in the log and outputs the count.
        /// </summary>
        /// <returns></returns>
        public static int CacheCount() {
            if (Filesystem.CacheExists()) {
                using (StreamReader readlog = new StreamReader(Path.Combine(Path.GetTempPath(), "dedotter-dir.log"))) {
                    int i = 0;
                    while (readlog.ReadLine() != null) {
                        i++;
                    }

                    return i;
                }
            } else {
                return 0;
            }
        }

        /// <summary>
        /// Checks if the cache exists.
        /// </summary>
        /// <returns></returns>
        public static bool CacheExists() {
            if (File.Exists(Path.Combine(Path.GetTempPath(), "dedotter-dir.log"))) {
                return true;
            } else {
                return false;
            }
        }
    }
}
