using Swiftly.Core.Model;

namespace Swiftly.Core
{
    public static class NotificationsHandler
    {
        public static void SendToastNotification(ToastNotificationType type, string message)
        {
            ToastUI ToastUI = new(type, message);
            ToastUI.Show();
        }
    }
}
