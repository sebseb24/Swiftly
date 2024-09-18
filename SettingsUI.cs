using SoundSwap.Core;
using SoundSwap.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoundSwap
{
    public partial class SettingsUI : Form
    {
        private readonly AudioSettingsHandler audioSettingsHandler;
        private readonly ProfilesManager profilesManager;

        public SettingsUI(AudioSettingsHandler audioSettingsHandler, ProfilesManager profilesManager)
        {
            this.audioSettingsHandler = audioSettingsHandler;
            this.profilesManager = profilesManager;

            InitializeComponent();

            RefreshProfilesListView();

            cb_OutputSelection.DataSource = audioSettingsHandler.GetAllOutputDevices();
            cb_InputSelection.DataSource = audioSettingsHandler.GetAllInputDevices();

            this.DialogResult = DialogResult.OK;
        }

        private void RefreshProfilesListView()
        {
            lv_Profiles.Items.Clear();

            foreach (var profile in profilesManager.Profiles())
            {
                lv_Profiles.Items.Add(profile.Name);
            }
        }

        private void RefreshFormFields(Profile? profile = null)
        {
            tb_NameSelection.Text = (profile == null) ? string.Empty : profile.Name;
            cb_OutputSelection.Text = (profile == null) ? string.Empty : profile.OutputDevice;
            cb_InputSelection.Text = (profile == null) ? string.Empty : profile.InputDevice;
            cb_IsActive.Checked = (profile == null) ? false : profile.IsActive;
        }

        private void bt_CreateProfile_Click(object sender, EventArgs e)
        {
            var name = tb_NameSelection.Text;
            var output = cb_OutputSelection.Text;
            var input = cb_InputSelection.Text;

            profilesManager.CreateEmptyProfile();

            RefreshProfilesListView();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            ListViewItem? item = lv_Profiles.SelectedItems.Count > 0 ? lv_Profiles.SelectedItems[0] : null;

            if (item == null)
                return;

            profilesManager.UpdateProfile(item.Text, tb_NameSelection.Text, cb_OutputSelection.Text, cb_InputSelection.Text, cb_IsActive.Checked);

            RefreshProfilesListView();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            ListViewItem? item = lv_Profiles.SelectedItems.Count > 0 ? lv_Profiles.SelectedItems[0] : null;

            if (item == null)
                return;

            profilesManager.DeleteProfile(item.Text);

            RefreshProfilesListView();
        }

        private void lv_Profiles_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem? item = lv_Profiles.SelectedItems.Count > 0 ? lv_Profiles.SelectedItems[0] : null;

            if (item == null)
                return;

            var profile = profilesManager.Find(item.Text);

            RefreshFormFields(profile);
        }
    }
}
