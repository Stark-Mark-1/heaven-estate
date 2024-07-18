using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModelInstantiater : MonoBehaviour
{
    public void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }


    [SerializeField] public GameObject[] models;
    [SerializeField] private GameObject[] UI;
    [SerializeField] private GameObject model;
    [SerializeField] public int arSceneIndex=0;
    [SerializeField] private GameObject delModel;
    //Functions for Instantiating 3D Models for 3d View
    public void HR()
    {
        model = models[0];
        Instantiate(model,new Vector3(0f, 0.779999971f, -8.25800037f), Quaternion.identity);
        arSceneIndex = 1;
    }
    public void BA()
    {
        model = models[1];
        Instantiate(model, new Vector3(-1.39999998f, -1.39000058f, 15.3400002f), Quaternion.identity);
        arSceneIndex = 2;
    }
    public void SV()
    {
        model = models[2];
        Instantiate(model, new Vector3(-0.0359999985f, 0.75f, -8.19200039f), Quaternion.identity);
        arSceneIndex = 3;
    }
    public void SS()
    {
        model = models[3];
        Instantiate(model, new Vector3(-0.0209999997f, 0.939999998f, -6.07700014f), Quaternion.identity);
        arSceneIndex = 4;
    }
    public void EE()
    {
        model = models[4];
        Instantiate(model, new Vector3(0.00100000005f, 0.939999998f, -8.35599995f), Quaternion.identity);
        arSceneIndex = 5;
    }

    //Funtction to destroy the current prefab available in the scene when the 3D View UI Closes
    public void Update()
    {
        delModel = GameObject.FindGameObjectWithTag("3d Model");
    }
    public void DeleteModel()
    {
        GameObject.Destroy(delModel);
        
        Debug.Log("Model Deleted");
    }

    //Functions to Open the arSceneIndex Scene for each Model
    public void arSceneOpener()
    {
        ARScene(arSceneIndex);
    }
    public void ARScene(int arSceneIndex)
    {
        if (arSceneIndex == 1)
        {
            SceneChanger("HR");
        }
        else if(arSceneIndex == 2)
        {
            SceneChanger("BA");
        }
        else if (arSceneIndex == 3)
        {
            SceneChanger("SV");
        }
        else if (arSceneIndex == 4)
        {
            SceneChanger("SS");
        }
        else if (arSceneIndex == 5)
        {
            SceneChanger("EE");
        }
        else if(UI[1].activeInHierarchy == true)
        {
            arSceneIndex = 1;
            SceneChanger("HR");
        }
        else if (UI[2].activeInHierarchy == true)
        {
            arSceneIndex = 2;
            SceneChanger("BA");
        }
        else if (UI[3].activeInHierarchy == true)
        {
            arSceneIndex = 3;
            SceneChanger("SV");
        }
        else if (UI[4].activeInHierarchy == true)
        {
            arSceneIndex = 4;
            SceneChanger("SS");
        }
        else if (UI[5].activeInHierarchy == true)
        {
            arSceneIndex = 5;
            SceneChanger("EE");
        }
    }
    public void SceneChanger(string arScene)
    {
        SceneManager.LoadScene(arScene);
    }

    //UI Manager function that makes use of Int arSceneIndex which lets it open the correct UI going back from 3d View
    public void UIManager()
    {

        DeleteModel();

        UI[0].SetActive(false);
        
        if(arSceneIndex == 1)
        {
            UI[1].SetActive(true);
        }
        else if (arSceneIndex == 2)
        {
            UI[2].SetActive(true);
        }
        else if (arSceneIndex == 3)
        {
            UI[3].SetActive(true);
        }
        else if (arSceneIndex == 4)
        {
            UI[4].SetActive(true);
        }
        else if (arSceneIndex == 5)
        {
            UI[5].SetActive(true);
        }
    }
    //funtion to reset the model in 3d View
    public void ResetModel()
    {
        DeleteModel();
        modelreseter(arSceneIndex);
    }
    private void modelreseter(int arSceneIndex)
    {
        if(arSceneIndex == 1)
        {
            HR();
        }
        else if(arSceneIndex == 2)
        {
            BA();
        }
        else if (arSceneIndex == 3)
        {
            SV();
        }
        else if (arSceneIndex == 4)
        {
            SS();
        }
        else if (arSceneIndex == 5)
        {
            EE();
        }
    }
    public void HomeScene()
    {
        SceneManager.LoadScene(2);
    }
    public int GetArSceneIndex()
    {
        return arSceneIndex;
    }

}
