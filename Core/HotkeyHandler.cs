using AudioSwitcher.AudioApi.CoreAudio;
using System.Runtime.InteropServices;
using System.Text;

namespace SoundSwap.Core
{
    public class HotkeyHandler
    {
        public int HOTKEY_ID { get; } = 1;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const uint MOD_CONTROL = 0x0002;  // Modifier for Ctrl

        const uint MOD_ALT = 0x0001;      // Modifier for Alt

        const uint VK_D = 0x44;           // Virtual-key code for 'D'

        public HotkeyHandler(nint handle)
        {
            RegisterHotKey(handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, VK_D);
        }

        public string GetCurrentHotkey()
        {
            return "Ctrl + Alt + D";
        }

    }
}
