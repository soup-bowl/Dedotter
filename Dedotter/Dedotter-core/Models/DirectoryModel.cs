using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedotter_core.Models {
    public class DirectorySearch {
        public DirectorySearch() {
            DirectoryObjects = new List<Dotfiles>();
        }
        public List<Dotfiles> DirectoryObjects { get; set; }
        public IList<string> DirectoryErrors { get; set; }
    }

    public class Dotfiles {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool VisibleFlag { get; set; }
    }
}
