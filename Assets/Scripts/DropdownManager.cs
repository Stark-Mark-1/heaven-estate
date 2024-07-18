using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    /*[SerializeField]
    GameObject States;*/
    [SerializeField]
    GameObject City1, City2, City3, City4, City5;
    public void CityActive(int index)
    {
        switch (index)
        {
            case 0:
                City1.SetActive(false);
                City2.SetActive(false);
                City3.SetActive(false);
                City4.SetActive(false);
                City5.SetActive(true);
                break;
            case 1:
                City1.SetActive(true);
                City2.SetActive(false);
                City3.SetActive(false);
                City4.SetActive(false);
                City5.SetActive(false);
                break;
            case 2:
                City1.SetActive(false);
                City2.SetActive(true);
                City3.SetActive(false);
                City4.SetActive(false);
                City5.SetActive(false);
                break;
            case 3:
                City1.SetActive(false);
                City2.SetActive(false);
                City3.SetActive(true);
                City4.SetActive(false);
                City5.SetActive(false);
                break;
            case 4:
                City1.SetActive(false);
                City2.SetActive(false);
                City3.SetActive(false);
                City4.SetActive(true);
                City5.SetActive(false);
                break;
        } 
    }
}
