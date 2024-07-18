using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOnPlane : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject objectToPlace;
    private GameObject newPlacedObj;
    private GameObject BeforePlacedObj;

    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }
    // public void SetObjectToPlace(GameObject objPrefab)
    // {
    //     objectToPlace = objPrefab; 
    // }

    // public void ClickToPlace()
    // {
    //    SetObjectToPlace(newPlacedObj);
    //    if (placeIndicator == null || placeIndicator.hasPlaced) return; // If object has already been placed or PlaceIndicator is missing, skip placement
    //    newPlacedObj = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
    //    
    //  }
    
    public void ClickToCheck()
    {
        if (objectToPlace == null)
        {
            return;
        }
        BeforePlacedObj = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);

    }
    public void ClickToPlace()
    {
        if (objectToPlace == null)
        {
            return;
        }
        if (BeforePlacedObj != null)
        {
            newPlacedObj = BeforePlacedObj;
            Instantiate(newPlacedObj, BeforePlacedObj.transform.position, BeforePlacedObj.transform.rotation);
            Destroy(BeforePlacedObj);
        }
        else
        {
            Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
        }
    }
}
