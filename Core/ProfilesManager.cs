using System.Text.Json;

using Swiftly.Core.Helpers;
using Swiftly.Core.Model;

namespace Swiftly.Core
{
    public class ProfilesManager
    {
        private const string profilesStorageFileName = "profiles.data";

        private readonly CircularList<Profile> profiles = new();

        private readonly AudioSettingsHandler audioSettingsHandler;

        private readonly StorageManager storageManager;

        private const string emptyProfileName = "Profile {0}";

        public ProfilesManager(AudioSettingsHandler audioSettingsHandler)
        {
            this.audioSettingsHandler = audioSettingsHandler;
            storageManager = new(profilesStorageFileName);

            LoadProfiles();
        }

        public List<Profile> Profiles()
        {
            return profiles.Items;
        }

        public Profile? Find(string name) => profiles.Items.FirstOrDefault(p => p.Name == name);

        public Profile? SetActiveProfileFromDevices(string outputName, string inputName)
        {
            var index = profiles.Items.FindIndex(p => p.OutputDevice == outputName && p.InputDevice == inputName);

            if (index >= 0)
            {
                profiles.SetIndexTo(index);

                return profiles.Items[index];
            }
            else
            {
                return null;
            }
        }

        public bool NextProfile(int nbRetry = 0)
        {
            var newProfile = profiles.NextElement();

            if (!newProfile.IsActive)
            {
                // This prevents infinite loop if all elements are inactive
                if (nbRetry > profiles.Items.Count)
                    return false;

                return NextProfile(++nbRetry);
            }

            return audioSettingsHandler.SetCurrentOutputDevice(newProfile.OutputDevice) && audioSettingsHandler.SetCurrentInputDevice(newProfile.InputDevice);
        }

        public void CreateEmptyProfile()
        {
            profiles.Items.Add(new Profile()
            {
                Name = GenerateEmptyProfileName(),
                OutputDevice = "",
                InputDevice = "",
            });

            SaveProfiles();
        }

        public void UpdateProfile(string initialName, string newName, string newOutputDevice, string newInputDevice, bool newIsActive)
        {
            var profile = Find(initialName);

            if (profile == null)
                return;

            if (NameIsAvailable(newName))
            {
                profile.Name = newName;
            }

            profile.OutputDevice = newOutputDevice;
            profile.InputDevice = newInputDevice;
            profile.IsActive = newIsActive;

            SaveProfiles();
        }

        public void DeleteProfile(string name)
        {
            var profile = Find(name);

            if (profile != null)
            {
                profiles.Items.Remove(profile);
            }

            SaveProfiles();
        }
        private void LoadProfiles()
        {
            var serializedProfiles = storageManager.Load();

            foreach (var serializedProfile in serializedProfiles)
            {
                profiles.Items.Add(JsonSerializer.Deserialize<Profile>(serializedProfile));
            }
        }

        private void SaveProfiles()
        {
            List<string> serializedProfiles = [];

            foreach (var profile in profiles.Items)
            {
                serializedProfiles.Add(JsonSerializer.Serialize(profile));
            }

            storageManager.Save(serializedProfiles);
        }

        private string GenerateEmptyProfileName(int index = 0)
        {
            var name = string.Format(emptyProfileName, index.ToString());

            if (!NameIsAvailable(name))
            {
                return GenerateEmptyProfileName(++index);
            }

            return name;
        }

        private bool NameIsAvailable(string name)
        {
            return profiles.Items.FirstOrDefault(p => p.Name == name) == null;
        }

    }
}
