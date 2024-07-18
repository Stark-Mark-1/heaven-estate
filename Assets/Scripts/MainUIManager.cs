using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : MonoBehaviour
{
    public static MainUIManager Instance;

    [SerializeField]
    private GameObject homescreen;

    [SerializeField]
    private GameObject[] everyOther;

    private void Awake()
    {
        CreateInstance();
    }

    private void CreateInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Openhome()
    {
        homescreen.SetActive(true);
        for (int i = 0; i < everyOther.Length; i++) {
            everyOther[i].SetActive(false); }
    }
}