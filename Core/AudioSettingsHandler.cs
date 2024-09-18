using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;

namespace SoundSwap.Core
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

        public void SetCurrentOutputDevice(string outputName)
        {
            coreAudioController.GetPlaybackDevices().ToList().FirstOrDefault(d => d.FullName.Contains(outputName, StringComparison.OrdinalIgnoreCase))?.SetAsDefault();
        }

        public void SetCurrentInputDevice(string inputName)
        {
            coreAudioController.GetCaptureDevices().ToList().FirstOrDefault(d => d.FullName.Contains(inputName, StringComparison.OrdinalIgnoreCase))?.SetAsDefault();
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
