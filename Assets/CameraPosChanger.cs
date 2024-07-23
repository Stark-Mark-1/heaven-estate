using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraPosChanger : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene(2);
    }
    public void GF()
    {
        SceneManager.LoadScene("360");
    }

    public void tf()
    {
        SceneManager.LoadScene("360(2)");
    }
}
