using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    [SerializeField]
    private float delaytoLoad = 3f;
    private float timeSpent;
    // Update is called once per frame

    public void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    void Update()
    {
        timeSpent += Time.deltaTime;
        if (timeSpent > delaytoLoad)
        {
            SceneManager.LoadScene(1);
        }
    }
}
