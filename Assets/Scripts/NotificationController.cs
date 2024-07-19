using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using Unity.Notifications.Android;

public class NotificationController : MonoBehaviour
{
    public void RequestAuth()
    {
        if (!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATIONS"))
        {
            Permission.RequestUserPermission("android.permission.POST_NOTIFICATIONS");
        }
    }

    public void RegisterChannel()
    {
        var channel = new AndroidNotificationChannel
        {
            Id = "default_channel",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "App Update Notifier"
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    public void SendNotifications(string tittle, string text, int FireIndHours)
    {
        var notification = new AndroidNotification();
        notification.Title = tittle;
        notification.Text = text;
        notification.FireTime = System.DateTime.Now;
        notification.SmallIcon = "icon_1";
        notification.LargeIcon = "icon_0";

        AndroidNotificationCenter.SendNotification(notification, "default_channel");
    }
}
