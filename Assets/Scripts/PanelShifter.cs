using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShifter : MonoBehaviour
{
    // Start is called before the first frame update
    public static PanelShifter Instance;

    [SerializeField]
    public GameObject MainP;
    [SerializeField]
    GameObject AboutUs;
    [SerializeField]
    GameObject Cat1;
    [SerializeField]
    GameObject Model1;
    [SerializeField]
    GameObject Model2;
    [SerializeField]
    GameObject Cat2;
    [SerializeField]
    GameObject Model3;
    [SerializeField]
    GameObject Model4;
    [SerializeField]
    GameObject Cat3;
    [SerializeField]
    GameObject Model5;
    [SerializeField]
    GameObject Model6;
    [SerializeField]
    GameObject TD1;
    [SerializeField]
    GameObject td2;
    [SerializeField]
    GameObject td3;
    [SerializeField]
    GameObject td4;
    [SerializeField]
    GameObject td5;
    [SerializeField]
    GameObject td6;
    [SerializeField]
    GameObject Calculator;
    [SerializeField]
    GameObject ManualCalci;
    [SerializeField]
    GameObject VVCalci;
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
    public void MainPanel()
    {
        MainP.SetActive(true);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void AU()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(true);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void c1()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(true);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void c2()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(true);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void c3()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(true);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void m1()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(true);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void m2()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(true);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void m3()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(true);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);

    }
    public void m4()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(true);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void m5()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(true);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void m6()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(true);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void Td1()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(true);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void TD2()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(true);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void TD3()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(true);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void TD4()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(true);
        td5.SetActive(false);
        td6.SetActive(false);
    }
    public void TD5()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(true);
        td6.SetActive(false);
    }
    public void TD6()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(true);
    }
    public void Calci()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
        Calculator.SetActive(true);
        ManualCalci.SetActive(false);
        VVCalci.SetActive(false);
    }
    public void MC()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
        Calculator.SetActive(false);
        ManualCalci.SetActive(true);
        VVCalci.SetActive(false);
    }
    public void VVC()
    {
        MainP.SetActive(false);
        AboutUs.SetActive(false);
        Cat1.SetActive(false);
        Cat2.SetActive(false);
        Cat3.SetActive(false);
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
        Model5.SetActive(false);
        Model6.SetActive(false);
        TD1.SetActive(false);
        td2.SetActive(false);
        td3.SetActive(false);
        td4.SetActive(false);
        td5.SetActive(false);
        td6.SetActive(false);
        Calculator.SetActive(false);
        ManualCalci.SetActive(false);
        VVCalci.SetActive(true);
    }
    public void Leave()
    {
        Application.Quit();
    }
}
