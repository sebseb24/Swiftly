using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;

namespace Swiftly.Core
{
    public class AudioSettingsHandler
    {
        private readonly CoreAudioController coreAudioController;

        public AudioSettingsHandler()
        {
            coreAudioController = new CoreAudioController();
        }

        public string GetCurrentOutputDevice()
        {
            return coreAudioController.DefaultPlaybackDevice.FullName;
        }

        public string GetCurrentInputDevice()
        {
            return coreAudioController.DefaultCaptureDevice.FullName;
        }

        public bool SetCurrentOutputDevice(string outputName)
        {
            return coreAudioController.GetPlaybackDevices().ToList().FirstOrDefault(d => d.FullName.Contains(outputName, StringComparison.OrdinalIgnoreCase))?.SetAsDefault() ?? false;
        }

        public bool SetCurrentInputDevice(string inputName)
        {
            return coreAudioController.GetCaptureDevices().ToList().FirstOrDefault(d => d.FullName.Contains(inputName, StringComparison.OrdinalIgnoreCase))?.SetAsDefault() ?? false;
        }

        public List<string> GetAllOutputDevices()
        {
            return coreAudioController.GetPlaybackDevices().Select(d => d.FullName).ToList();
        }

        public List<string> GetAllInputDevices()
        {
            return coreAudioController.GetCaptureDevices().Select(d => d.FullName).ToList();
        }
    }
}
