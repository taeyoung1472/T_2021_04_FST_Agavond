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
            if (Onclick == true)
            {
                transform.Rotate(0f, Input.GetAxis("Mouse X") * speed, 0f);
            }
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