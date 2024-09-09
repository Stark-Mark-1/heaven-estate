using UnityEngine;

public class androidColorMatcher : MonoBehaviour
{
    void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        // Set status bar background color to white
        Color32 statusBarColor = new Color32(255, 255, 255, 255); // White color
        SetBarColor(statusBarColor, "setStatusBarColor");

        // Set status bar text and icons to black (light status bar mode)
        SetLightStatusBar();

        // Set navigation bar background color to white
        Color32 navigationBarColor = new Color32(255, 255, 255, 255); // White color
        SetBarColor(navigationBarColor, "setNavigationBarColor");

        // Set navigation bar icons to black
        SetLightNavigationBar();

        // Clear full screen flags to ensure the status and navigation bars are visible
        ClearFlags(1024); // WindowManager.LayoutParams.FLAG_FULLSCREEN = 1024
#endif
    }

    void SetBarColor(Color color, string methodName)
    {
        RunOnUiThread(() => GetWindow().Call(methodName, ColorToARGB(color)));
    }

    void ClearFlags(int flags)
    {
        RunOnUiThread(() => GetWindow().Call("clearFlags", flags));
    }

    void SetLightStatusBar()
    {
        RunOnUiThread(() =>
        {
            AndroidJavaObject window = GetWindow();
            AndroidJavaObject decorView = window.Call<AndroidJavaObject>("getDecorView");

            int systemUiVisibility = decorView.Call<int>("getSystemUiVisibility");
            systemUiVisibility |= 0x00002000; // SYSTEM_UI_FLAG_LIGHT_STATUS_BAR = 0x00002000
            decorView.Call("setSystemUiVisibility", systemUiVisibility);
        });
    }

    void SetLightNavigationBar()
    {
        RunOnUiThread(() =>
        {
            AndroidJavaObject window = GetWindow();
            AndroidJavaObject decorView = window.Call<AndroidJavaObject>("getDecorView");

            int systemUiVisibility = decorView.Call<int>("getSystemUiVisibility");
            systemUiVisibility |= 0x00000010; // SYSTEM_UI_FLAG_LIGHT_NAVIGATION_BAR = 0x00000010
            decorView.Call("setSystemUiVisibility", systemUiVisibility);
        });
    }

    AndroidJavaObject GetWindow()
    {
        AndroidJavaClass windowClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject activity = windowClass.GetStatic<AndroidJavaObject>("currentActivity");
        return activity.Call<AndroidJavaObject>("getWindow");
    }

    void RunOnUiThread(System.Action action)
    {
        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject activity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call("runOnUiThread", new AndroidJavaRunnable(action));
    }

    int ColorToARGB(Color32 color)
    {
        int value = 0;
        value |= color.a << 24; // Alpha
        value |= color.r << 16; // Red
        value |= color.g << 8;  // Green
        value |= color.b;       // Blue
        return value;
    }
}
