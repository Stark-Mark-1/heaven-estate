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

    void Start()
    {
        if (indicator == null)
        {
            Debug.LogError("Indicator is not assigned in the Inspector!");
            return;
        }

        // Optionally set the indicator to the first tab's position (Home) when the scene starts
        MoveIndicatorTo(homeX);
    }

    // Function to move the indicator to a given X-axis position
    void MoveIndicatorTo(float targetX)
    {
        if (indicator != null)
        {
            Debug.Log("Moving indicator to X position: " + targetX);

            // Get the current anchoredPosition of the indicator
            Vector2 newPosition = indicator.anchoredPosition;

            // Change only the X position
            newPosition.x = targetX;

            // Set the new anchoredPosition (UI-relative local position)
            indicator.anchoredPosition = newPosition;

            Debug.Log("Indicator moved to anchored position: " + indicator.anchoredPosition);
        }
        else
        {
            Debug.LogError("Indicator reference is missing!");
        }
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
