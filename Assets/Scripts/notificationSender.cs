using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;
using UnityEngine.Android;

public class notificationSender : MonoBehaviour
{
    [SerializeField] NotificationController notificationController;

    private void Start()
    {
        notificationController.RequestAuth();
        notificationController.RegisterChannel();
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus == false)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            notificationController.SendNotifications("New Update", "hey there new app update is live on landing page", 0);
        }
    }
}
