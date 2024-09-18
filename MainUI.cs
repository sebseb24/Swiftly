using System.Runtime.InteropServices;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Linq;
using SoundSwap.Core;
using System.Transactions;
using System.Windows.Forms;

namespace SoundSwap
{
    public partial class SoundSwap : Form
    {
        private readonly HotkeyHandler hotkeyHandler;
        private readonly AudioSettingsHandler audioSettingsHandler;
        private readonly ProfilesManager profilesManager;

        public SoundSwap()
        {
            hotkeyHandler = new HotkeyHandler(this.Handle);
            audioSettingsHandler = new AudioSettingsHandler();
            profilesManager = new ProfilesManager(audioSettingsHandler);

            InitializeComponent();

            RefreshLabels();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == hotkeyHandler.HOTKEY_ID)
                {
                    profilesManager.NextProfile();
                    RefreshLabels();
                }
            }

            base.WndProc(ref m);
        }

        private void RefreshLabels()
        {

            lb_selectedOutput.Text = audioSettingsHandler.GetCurrentOutputDevice();
            lb_selectedInput.Text = audioSettingsHandler.GetCurrentInputDevice();

            lb_SelectedHotkey.Text = hotkeyHandler.GetCurrentHotkey();

            var currentProfile = profilesManager.SetActiveProfileFromDevices(lb_selectedOutput.Text, lb_selectedInput.Text);

            lb_selectedProfile.Text = (currentProfile != null) ? currentProfile.Name : "<None>";
        }

        private void bt_Settings_Click(object sender, EventArgs e)
        {
            using (SettingsUI SettingsUI = new(audioSettingsHandler, profilesManager))
            {
                SettingsUI.ShowDialog();

                RefreshLabels();
            }
        }

        private void ni_NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SoundSwap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
    }
}
