using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ThreesixtyNavigate : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene(2);
    }
    public void TS()
    {
        SceneManager.LoadScene("Bed Room");
    }
    public void Bedroom()
    {
        SceneManager.LoadScene("Bed room");

    }
    public void Dining()
    {
        SceneManager.LoadScene("Dining");
        Debug.Log("it works");

    }
    public void stairsUp()
    {
        SceneManager.LoadScene("Stairs up");

    }
    public void stairsMid()
    {
        SceneManager.LoadScene("Stairs mid");

    }
    public void stairsDown()
    {
        SceneManager.LoadScene("Stairs down");

    }
    public void Enterence()
    {
        SceneManager.LoadScene("Enterance");

    }
    public void outEnterence()
    {
        SceneManager.LoadScene("out Enterance");

    }
}
