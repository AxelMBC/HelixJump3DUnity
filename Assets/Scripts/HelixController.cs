using UnityEngine;

public class HelixController : MonoBehaviour
{
    private Vector2 lastTapPosition;

    private Vector3 startPosition;


    void Start()
    {
        startPosition = transform.localEulerAngles;
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 currentTabPosition = Input.mousePosition;

            if (lastTapPosition == Vector2.zero)
            {
                lastTapPosition = currentTabPosition;

            }
            float distance = lastTapPosition.x - currentTabPosition.x;
            lastTapPosition = currentTabPosition;

            transform.Rotate(Vector3.up * distance);
        }

        if (Input.GetMouseButtonUp(0))
        {
            lastTapPosition = Vector2.zero;
        }
    }
}
