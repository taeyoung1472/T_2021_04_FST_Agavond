/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObject : MonoBehaviour
{
    //케릭터의 움직임
    public Joystick Joystick;
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {

        float x = Joystick.Horizontal();
        float z = Joystick.Vertical();

        if (x != 0 || z != 0)
        {
            transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
        }
        
    }

}*/