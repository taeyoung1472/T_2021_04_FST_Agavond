using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.5f;
    public bool Onclick;
    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Onclick == true)
            {
                transform.Rotate(0f, Input.GetAxis("Mouse X") * speed, 0f);
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
    public void onClick()
    {
        Onclick = true;
    }
    public void outClick()
    {
        Onclick = false;
    }
}