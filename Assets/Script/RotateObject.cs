using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && !IsTouchOverUIElement())
        {
            Vector2 touchDeltaPos = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, touchDeltaPos.x * rotateSpeed, 0);
        }
    }

    bool IsTouchOverUIElement()
    {
        if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
        {
            return true;
        }
        return false;
    }
}
