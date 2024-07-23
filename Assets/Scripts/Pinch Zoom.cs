using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    public float zoomSpeed = 0.5f;
    public float minFOV = 10f;
    public float maxFOV = 60f;

    private float initialPinchDistance;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
            {
                initialPinchDistance = Vector2.Distance(touch1.position, touch2.position);
            }
            else if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
                float currentPinchDistance = Vector2.Distance(touch1.position, touch2.position);

                // Calculate pinch difference and adjust the field of view
                float pinchDifference = initialPinchDistance - currentPinchDistance; // Invert the pinch
                Camera.main.fieldOfView += pinchDifference * zoomSpeed;

                // Clamp the field of view to prevent it from going beyond min and max values
                Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minFOV, maxFOV);

                // Update the initial pinch distance for the next frame
                initialPinchDistance = currentPinchDistance;
            }
        }
    }
}
