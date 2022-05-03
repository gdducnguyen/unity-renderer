using System;
using BLD.NotificationModel;

public interface INotification
{
    event Action<INotification> OnNotificationDismissed;
    Model model { get; }
    void Show(Model model);
    void Dismiss(bool instant);
}