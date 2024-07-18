using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field1, field2;
    [SerializeField] TMP_Text ans;

    public void Calc()
    {
        float num1 = float.Parse(field1.text);
        float num2 = float.Parse(field2.text);
        float area = num1 * num2;
        ans.text = "Estimated Cost : " + area + " Rs";
    }
}
