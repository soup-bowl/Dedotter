using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dedotter_core {
    public class Security {
        /// <summary>
        /// Detects if the system is running as admin.
        /// </summary>
        /// <returns></returns>
        public static bool IsAdministrator() {
            // Credit goes to this SO answer - http://stackoverflow.com/a/11660205
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
