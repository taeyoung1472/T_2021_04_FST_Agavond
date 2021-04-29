using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetRotation : MonoBehaviour
{
    public Transform cameraTransform;
    public float cameraSensitvivity;

    int leftInput, rightInput;

    Vector2 lookInput;
    float cameraPitch;
    public bool click;
    void Start()
    {
        leftInput = -1;
        rightInput = -1;
    }
 
    // Update is called once per frame
    void Update()
    {
        GetTouchInput();

        if(rightInput != -1)
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
                    if (t.position.x > 980&& leftInput == -1)
                    {
                        leftInput = t.fingerId;
                    }
                    else if (t.position.x < 980 && leftInput == -1)
                    {
                        rightInput = t.fingerId;
                    }
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    if (t.fingerId == leftInput)
                    {
                        leftInput = t.fingerId;
                    }
                    else if (t.fingerId == rightInput)
                    {
                        rightInput = t.fingerId;
                    }
                    break;
                case TouchPhase.Moved:
                    if(t.fingerId == rightInput)
                    {
                        lookInput = t.deltaPosition;
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
        cameraPitch = Mathf.Clamp(cameraPitch + lookInput.y * -cameraSensitvivity * Time.deltaTime, -45f, 45f);
        cameraTransform.localRotation = Quaternion.Euler(cameraPitch, 0, 0);

        transform.Rotate(transform.up, lookInput.x * cameraSensitvivity * Time.deltaTime);
    }
    public void OnClick()
    {
        click = true;
        Debug.Log("회전시작");
    }
    public void OutClick()
    {
        click = false;
        Debug.Log("회전끝");
    }
}