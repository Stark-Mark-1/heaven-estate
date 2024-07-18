using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public void Load800I()
    {
        SceneManager.LoadScene("600 800 1");
    }
    public void Load800II()
    {
        SceneManager.LoadScene("600 800 2");
    }
    public void Load1000I()
    {
        SceneManager.LoadScene("800-1000 1");
    }
    public void Load1000II()
    {
        SceneManager.LoadScene("800-1000 2");
    }
    public void Load1200I()
    {
        SceneManager.LoadScene("1000-1200 1");
    }
    public void Load1200II()
    {
        SceneManager.LoadScene("1000-1200 2");
    }
    public void Leave()
    {
        SceneManager.LoadScene(2);
    }  
}
