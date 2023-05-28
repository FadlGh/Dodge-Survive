using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    private bool touchedRight = false;
    private bool touchedLeft = false;

    // Adjust this value to control the speed of player movement
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        // Check for touch input on mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if touch is on the right or left half of the screen
            if (touch.position.x > Screen.width / 2)
            {
                touchedRight = true;
                touchedLeft = false;
            }
            else
            {
                touchedRight = false;
                touchedLeft = true;
            }
        }
        else
        {
            touchedRight = false;
            touchedLeft = false;
        }
    }

    private void FixedUpdate()
    {
        // Move the player based on the touch input
        if (touchedRight)
        {
            // Move player to the right
            transform.Translate(Vector3.right * moveSpeed * Time.fixedDeltaTime);
        }
        else if (touchedLeft)
        {
            // Move player to the left
            transform.Translate(Vector3.left * moveSpeed * Time.fixedDeltaTime);
        }
    }
}