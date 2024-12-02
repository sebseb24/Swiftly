using System.Linq;
using Swiftly.Core;
using System.Transactions;
using System.Windows.Forms;
using Swiftly.Core.Model;

namespace Swiftly
{
    public partial class Swiftly : Form
    {
        private readonly string VERSION = "v1.0.1";

        private readonly HotkeyHandler hotkeyHandler;
        private readonly AudioSettingsHandler audioSettingsHandler;
        private readonly ProfilesManager profilesManager;

        public Swiftly()
        {
            this.Text = $"Swiftly {VERSION}";

            hotkeyHandler = new HotkeyHandler(this.Handle);
            audioSettingsHandler = new AudioSettingsHandler();
            profilesManager = new ProfilesManager(audioSettingsHandler);

            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            RefreshLabels();

#if DEBUG
            this.WindowState = FormWindowState.Normal;
#endif
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == hotkeyHandler.HOTKEY_ID)
                {
                    if (profilesManager.NextProfile())
                    {
                        RefreshLabels();
                        NotificationsHandler.SendToastNotification(ToastNotificationType.Info, $"Audio device changed to '{lb_selectedProfile.Text}'");
                    }
                    else
                    {
                        RefreshLabels();
                        NotificationsHandler.SendToastNotification(ToastNotificationType.Error, $"Error while setting audio devices.");
                    }
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

#if !DEBUG
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
#endif

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Swiftly_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
    }
}
