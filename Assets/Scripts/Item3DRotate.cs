using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item3DRotate : MonoBehaviour
{
    [SerializeField] private float rotationPercentage = 0.2f;
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                transform.eulerAngles -= new Vector3(0, touch.deltaPosition.x * rotationPercentage, 0); 
            }
        }
    }
}
