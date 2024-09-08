using Pepris.Properties;
using System.Media;
using System.Runtime.InteropServices;

namespace Pepris {
    internal class Sounds : IDisposable {
        private Settings settings = new Settings();

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private void SetVolume(int volume) {
            uint mappedVolume = (uint)((volume * 0xFFFF) / 100);
            waveOutSetVolume(IntPtr.Zero, mappedVolume | (mappedVolume << 16));
        }

        // navigation
        public SoundPlayer back = new SoundPlayer(Resources.back);
        public SoundPlayer forward = new SoundPlayer(Resources.forward);
        public SoundPlayer hover = new SoundPlayer(Resources.hover);
        public SoundPlayer load = new SoundPlayer(Resources.load);
        public SoundPlayer save = new SoundPlayer(Resources.save);
        public SoundPlayer pause = new SoundPlayer(Resources.pause);
        public SoundPlayer unpause = new SoundPlayer(Resources.unpause);
        public SoundPlayer error = new SoundPlayer(Resources.error);

        // gameplay
        public SoundPlayer combo1 = new SoundPlayer(Resources.combo1);
        public SoundPlayer combo2 = new SoundPlayer(Resources.combo2);
        public SoundPlayer combo3 = new SoundPlayer(Resources.combo3);
        public SoundPlayer combo4 = new SoundPlayer(Resources.combo4);
        public SoundPlayer combo5 = new SoundPlayer(Resources.combo5);

        public void Play(SoundPlayer sound) {
            if (settings.GetSettingBool("useSfx")) {
                SetVolume(settings.GetSettingInt("sfxVolume"));
                sound.Play();
            }
        }

        public void Dispose() {
            back.Dispose();
            forward.Dispose();
            hover.Dispose();
            load.Dispose();
            save.Dispose();
            pause.Dispose();
            unpause.Dispose();
            error.Dispose();
            combo1.Dispose();
            combo2.Dispose();
            combo3.Dispose();
            combo4.Dispose();
            combo5.Dispose();
        }
    }
}
