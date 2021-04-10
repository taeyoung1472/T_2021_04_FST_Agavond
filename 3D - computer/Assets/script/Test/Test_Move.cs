using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Move : MonoBehaviour
{
    public Vector3 speedvec;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedvec = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            speedvec.z += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            speedvec.x -= speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            speedvec.z -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            speedvec.x += speed;
        }
        transform.Translate(speedvec * Time.deltaTime);
    }
}
