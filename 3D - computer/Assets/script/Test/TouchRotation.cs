using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchRotation : MonoBehaviour
{
    public Transform cameraTransform;
    public float cameraSensitvivity;

    public int leftInput, rightInput;
    public Vector2 lookInput;
    public float cameraPitch;
    public float cameraPitchTotal;
    public float halfScreenWidth;
    public GUN gun;
    public float  a;
    void Start()
    {
        leftInput = -1;
        rightInput = -1;

        halfScreenWidth = Screen.width / 2;
        //a = gun.reboundY;
    }
 
    // Update is called once per frame
    void Update()
    {
        GetTouchInput();

        if (rightInput != -1)
        {
            LookAround();
        }
    }
    void GetTouchInput()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {   
            Touch t = Input.GetTouch(i);

            switch (t.phase)
            {
                case TouchPhase.Began:
                    if (t.position.x < halfScreenWidth&& leftInput == -1)
                    {
                        leftInput = t.fingerId;
                    }
                    if (t.position.x > halfScreenWidth && rightInput == -1)
                    {
                        rightInput = t.fingerId;
                    }
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    if (t.fingerId == leftInput)
                    {
                        leftInput = -1;
                    }
                    if (t.fingerId == rightInput)
                    {
                        rightInput = -1;
                    }
                    break;
                case TouchPhase.Moved:
                    if(t.fingerId == rightInput)
                    {
                        lookInput = t.deltaPosition * cameraSensitvivity * Time.deltaTime;
                    }
                    break;
                case TouchPhase.Stationary:
                    if (t.fingerId == rightInput)
                    {
                        lookInput = Vector2.zero;
                    }
                    break;
            }
        }
    }
    void LookAround()
    {
        cameraPitchTotal += a;
        cameraPitchTotal = Mathf.Clamp(cameraPitchTotal - lookInput.y, -20f, 20f);
        cameraTransform.localRotation = Quaternion.Euler(cameraPitchTotal, 0, 0) ;

        transform.Rotate(transform.up, lookInput.x);
    }
    public void rebound(float x,float y)
    {
        a = x;
        cameraPitchTotal += a;
        cameraPitchTotal = Mathf.Clamp(cameraPitchTotal - lookInput.y, -20f, 20f);
        cameraTransform.localRotation = Quaternion.Euler(cameraPitchTotal, 0, 0);
        a = 0;
        transform.Rotate(transform.up, y);
    }
}