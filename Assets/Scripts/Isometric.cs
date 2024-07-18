using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Isometric : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;
    [SerializeField] ModelInstantiater modelInfo;
    [SerializeField] private float camYOffset = 0.3f; // default
    [SerializeField] GameObject resetButton;
    [SerializeField] GameObject arButton;
    [SerializeField] GameObject tsButton;
    Toggle toggle;
    Vector2 handlePosition;
    Vector3 originalCameraPosition;
    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        handlePosition = uiHandleRectTransform.anchoredPosition;
        originalCameraPosition = Camera.main.transform.position;
        
        toggle.onValueChanged.AddListener(OnSwitch);
        OnSwitch(toggle.isOn);
    }
    void OnSwitch(bool on)
    {
        uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;
        if (on)
        {
            int modelNum = modelInfo.GetArSceneIndex();
            if (modelNum == 2)
            {
                camYOffset = 5f;
            }
            else if (modelNum == 4)
            {
                camYOffset = 0.7f;
            }
            else
            {
                camYOffset = 0.3f; // Default offset for other models
            }
            Camera.main.transform.position = new Vector3(
                originalCameraPosition.x,
                originalCameraPosition.y + camYOffset,
                originalCameraPosition.z);
            resetButton.SetActive(false);
            arButton.SetActive(false);
            tsButton.SetActive(false);
        }
        else
        {
            buttonOn();
            Camera.main.transform.position = originalCameraPosition;
        }
    }
    void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener(OnSwitch);
        
    }
    void camPosChange(int modelNum)
    {
        if(modelNum == 3)
        {
            camYOffset = 1f;
            Camera.main.transform.position = new Vector3(
                originalCameraPosition.x,
                originalCameraPosition.y + camYOffset,
                originalCameraPosition.z);
        }
        else if(modelNum == 4)
        {
            camYOffset = 0.7f;
            Camera.main.transform.position = new Vector3(
                originalCameraPosition.x,
                originalCameraPosition.y + camYOffset,
                originalCameraPosition.z);
        }
        else
        {
            Camera.main.transform.position = new Vector3(
                originalCameraPosition.x,
                originalCameraPosition.y + camYOffset,
                originalCameraPosition.z);
        }
    }
    void ButtonOff()
    {
    }
    void buttonOn()
    {
        resetButton.SetActive(true);
        arButton.SetActive(true);
        tsButton.SetActive(true);
    }
}
