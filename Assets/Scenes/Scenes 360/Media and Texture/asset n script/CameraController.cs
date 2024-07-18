using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Sensitivity of camera rotation
    public float rotationSpeed = 0.1f;

    private Vector2 touchStartPos;
    private bool isRotating;

    void Update()
    {
        // Check for mobile touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check for touch phase
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Record the starting touch position
                    touchStartPos = touch.position;
                    isRotating = true;
                    break;

                case TouchPhase.Moved:
                    if (isRotating)
                    {
                        // Calculate the difference in touch positions
                        Vector2 delta = touch.position - touchStartPos;

                        // Calculate the camera rotation angles
                        float rotationX = -delta.y * rotationSpeed;
                        float rotationY = delta.x * rotationSpeed;

                        // Apply the rotation to the camera, locking the Z-axis rotation
                        transform.Rotate(Vector3.right, rotationX);
                        transform.Rotate(Vector3.up, rotationY);
                        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

                        // Update the touch start position for the next frame
                        touchStartPos = touch.position;
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    isRotating = false;
                    break;
            }
        }
    }
}

