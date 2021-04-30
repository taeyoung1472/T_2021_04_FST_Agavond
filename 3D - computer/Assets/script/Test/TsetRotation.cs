using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetRotation : MonoBehaviour
{
    public Transform cameraTransform;
    public float cameraSensitvivity;

    public int leftInput, rightInput;
    Vector2 lookInput;
    float cameraPitch;
    public float halfScreenWidth;
    void Start()
    {
        leftInput = -1;
        rightInput = -1;

        halfScreenWidth = Screen.width / 2;
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
                    if (t.position.x > halfScreenWidth && leftInput == -1)
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
                    else if (t.fingerId == rightInput)
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
        cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -20f, 20f);
        cameraTransform.localRotation = Quaternion.Euler(cameraPitch, 0, 0);

        transform.Rotate(transform.up, lookInput.x);
    }
}