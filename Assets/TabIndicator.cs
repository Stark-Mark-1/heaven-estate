using UnityEngine;

public class TabIndicator : MonoBehaviour
{
    public RectTransform indicator; // The indicator's RectTransform

    // X-axis positions for each tab (manually set these in Unity Inspector or code)
    public float homeX;
    public float searchX;
    public float demoX;
    public float bookmarkX;
    public float profileX;

    public float moveSpeed = 0.7f; // Speed of the elastic movement
    private Vector2 currentVelocity = Vector2.zero; // Used by SmoothDamp for smoothing the movement
    private float smoothTime = 0.1f; // Time it takes to smooth the movement (adjust for a more elastic feel)

    private float targetX; // Stores the target X position

    void Start()
    {
        if (indicator == null)
        {
            Debug.LogError("Indicator is not assigned in the Inspector!");
            return;
        }

        // Set the initial target to the home tab's position
        targetX = homeX;
        MoveIndicatorTo(homeX);
    }

    void Update()
    {
        // Continuously smooth the movement towards the target position
        SmoothMoveIndicator();
    }

    // Function to move the indicator to a given X-axis position
    void MoveIndicatorTo(float newTargetX)
    {
        Debug.Log("Moving indicator to X position: " + newTargetX);
        targetX = newTargetX;
    }

    void SmoothMoveIndicator()
    {
        // Get the current anchored position of the indicator
        Vector2 currentPosition = indicator.anchoredPosition;

        // Smoothly move towards the target X position using SmoothDamp
        currentPosition.x = Mathf.SmoothDamp(currentPosition.x, targetX, ref currentVelocity.x, smoothTime);

        // Update the indicator's position
        indicator.anchoredPosition = currentPosition;

        Debug.Log("Current Indicator Position: " + indicator.anchoredPosition);
    }

    // Function for the Home tab
    public void Home()
    {
        Debug.Log("Home tab selected.");
        MoveIndicatorTo(homeX);
    }

    // Function for the Search tab
    public void Search()
    {
        Debug.Log("Search tab selected.");
        MoveIndicatorTo(searchX);
    }

    // Function for the Demo tab
    public void Demo()
    {
        Debug.Log("Demo tab selected.");
        MoveIndicatorTo(demoX);
    }

    // Function for the Bookmark tab
    public void Bookmark()
    {
        Debug.Log("Bookmark tab selected.");
        MoveIndicatorTo(bookmarkX);
    }

    // Function for the Profile tab
    public void Profile()
    {
        Debug.Log("Profile tab selected.");
        MoveIndicatorTo(profileX);
    }
}
