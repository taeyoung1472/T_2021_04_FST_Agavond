using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    Vector2 MousePosition;
    Camera Camera;

    private void Start()
    {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MousePosition = Input.mousePosition;
            //transform.position = MousePosition;
            //Debug.Log(MousePosition);
            if (MousePosition.x > 960)
            {
                transform.Rotate(0f, Input.GetAxis("Mouse X") * speed, 0f, Space.World);
                //transform.Rotate(-Input.GetAxis("Mouse Y") * speed, 0f, 0f);
            }
        }
        /*{
            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f, Space.World);
                //transform.Rotate(-Input.GetAxis("Mouse Y") * speed, 0f, 0f);
            }
        }*/
    }
}