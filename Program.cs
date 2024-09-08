using System.Runtime.InteropServices;

namespace Pepris {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu());
        }
    }
}