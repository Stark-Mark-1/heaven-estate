using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UP : MonoBehaviour
{
    [SerializeField]
    TMP_Text price;
    [SerializeField]
    TMP_Text TotCost;
    [SerializeField]
    TMP_InputField area;
    [SerializeField]
    TMP_Text desc;
    float costpsqf = 0f;
    public void PriceRetriever(int index)
    {
        switch (index) 
        {
            case 1:
                costpsqf = 1202f;
                price.text = "Price Per SqFt : " + costpsqf + " Rs.";
                float ar = float.Parse(area.text);
                float tot = ar * costpsqf;
                TotCost.text = "Est Building Cost : " + tot + " Rs.";
                desc.text = "Quantity of Materials for Materials: " +
                            "Cement                \t" + ar * .45 + " bags\n" +
                            "Steel                 \t" + ar * .35 + " Kgs\n" +
                            "Bricks                \t" + ar * 19  + " Pieces\n" +
                            "Aggregate             \t" + ar * .19 + " / cu ft\n" +
                            "Sand                  \t" + ar * .2  + " / cu ft\n" +
                            "Flooring              \t" + ar * .1  + " / Sq ft\n" +
                            "Windows               \t" + ar * .17 + " / Sq ft\n" +
                            "Doors                 \t" + ar * .18 + " / Sq ft\n" +
                            "Electrical Fitting    \t" + ar * .15 + " / Sq ft\n" +
                            "Paint                 \t" + ar * .6  + " / Sq ft\n" +
                            "Sanitary Fitting      \t" + ar * .1  + " / Sq ft\n" +
                            "Kitchen Work         " + ar * .05 + " / Sq ft\n";
                break;
            case 2:
                costpsqf = 1300f;
                price.text = "Price Per SqFt : " + costpsqf + " Rs.";
                ar = float.Parse(area.text);
                tot = ar * costpsqf;
                TotCost.text = "Est Building Cost : " + tot + " Rs.";
                desc.text = "Quantity of Materials for Materials: " +
                            "Cement                \t" + ar * .45 + " bags\n" +
                            "Steel                 \t" + ar * .35 + " Kgs\n" +
                            "Bricks                \t" + ar * 19 + " Pieces\n" +
                            "Aggregate             \t" + ar * .19 + " / cu ft\n" +
                            "Sand                  \t" + ar * .2 + " / cu ft\n" +
                            "Flooring              \t" + ar * .1 + " / Sq ft\n" +
                            "Windows               \t" + ar * .17 + " / Sq ft\n" +
                            "Doors                 \t" + ar * .18 + " / Sq ft\n" +
                            "Electrical Fitting    \t" + ar * .15 + " / Sq ft\n" +
                            "Paint                 \t" + ar * .6 + " / Sq ft\n" +
                            "Sanitary Fitting      \t" + ar * .1 + " / Sq ft\n" +
                            "Kitchen Work         " + ar * .05 + " / Sq ft\n";
                break;
        }
    }
}
