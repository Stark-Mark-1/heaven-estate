using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class priceCalculator : MonoBehaviour
{
    [SerializeField]
    TMP_Text Cost;
    Dropdown DD;
    /*public float cost=0;*/
    int costing;
    public void CostRetriever(string Value)
    {
        switch (Value)
        {
            case "Allahabad":
                costing = 1200;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Azamgarh":
             costing = 1300;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Guna":
                costing = 1625;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Gwalior":
                costing = 1800;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Gurgaon":
                costing = 2200;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Ambala":
                costing = 1900;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Patna":
                costing = 1800;
                Cost.text = "Cost per Sqft: " + costing;
                break;
            case "Gaya":
                costing = 1650;
                Cost.text = "Cost per Sqft: " + costing;
                break;
        }
    }
    
}
