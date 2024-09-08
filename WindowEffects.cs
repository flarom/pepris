using System.Runtime.InteropServices;

namespace Pepris {
    internal class WindowEffects {
        const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        [DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public static void useDarkBorder(IntPtr handle, bool enabled) {
            var version = Environment.OSVersion.Version;
            if (version.Major >= 10 && version.Build >= 17763) {
                int useImmersiveDarkMode = enabled ? 1 : 0;
                DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));
            }
        }

        public static async Task fadeOut(Form form) {
            form.Opacity = 1;
            while (form.Opacity > 0) {
                form.Opacity -= 0.1;
                await Task.Delay(1);
            }
        }

        public static async Task fadeIn(Form form) {
            form.Opacity = 0;
            while(form.Opacity < 1) {
                form.Opacity += 0.1;
                await Task.Delay(1);
            }
        }
    }
}
