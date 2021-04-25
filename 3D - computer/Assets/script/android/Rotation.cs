using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float speed = 60f;
    public bool Onclick;
    public bool A;
    public bool IsLeft;
    public int PointerId;
    public Vector2 PointerOld;
    public Vector2 TouchDist;
    private void Start()
    {

    }
    void Update()
    {
        if (Onclick)
        {
            PointerOld = Input.mousePosition;
            if (PointerOld.x < TouchDist.x - 50)
            {
                transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
            }
            else if (PointerOld.x > TouchDist.x + 50)
            {
                transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
            }
            //else //(PointerOld.x == TouchDist.x)
            //IsLeft = false; A = false;
            //else (PointerOld.x < TouchDist.x)
            //IsLeft = true;
            if (PointerOld.x == TouchDist.x)
            {
                IsLeft = false;
                A = false;
            }
            //왼쪽
            /*if (IsLeft == true)
            {
                if (TouchDist.x < PointerOld.x + 100)
                {
                    transform.Rotate(new Vector3(0, -speed * Time.deltaTime * 0.1f, 0));
                    Debug.Log("1단계");
                }
                else if (TouchDist.x < PointerOld.x + 200)
                {
                    transform.Rotate(new Vector3(0, -speed * Time.deltaTime * 0.5f, 0));
                    Debug.Log("2단계");
                }
                else
                {
                    transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
                    Debug.Log("3단계");
                }
            }
            //오른쪽
            if (A == true)
            {
                if (PointerOld.x < TouchDist.x + 100)
                {
                    transform.Rotate(new Vector3(0, speed * Time.deltaTime * 0.1f, 0));
                    Debug.Log("1단계");
                }
                else if (PointerOld.x < TouchDist.x + 200)
                {
                    transform.Rotate(new Vector3(0, speed * Time.deltaTime * 0.5f, 0));
                    Debug.Log("2단계");
                }
                else
                {
                    transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
                    Debug.Log("3단계");
                }
            }*/
        }
    }
    public void onClick()
    {
        TouchDist = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Onclick = true;
    }
    public void outClick()
    {
        PointerOld = new Vector2(0,0);
        Onclick = false;
    }
}