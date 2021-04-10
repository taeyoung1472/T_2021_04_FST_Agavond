using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Rigidbody myrigid;
    public float sensitivityX = 15.0f;
    public float BasicRotationX;
    public float BasicRotationY;
    //public float sensitivityY = 15.0f;

    //public float minimumY = -60.0f;
    //public float maximumY = 60.0f;

    float rotationX = 0.0f;
    //float rotationY = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;

        myrigid.transform.localEulerAngles = new Vector3(BasicRotationX, rotationX, BasicRotationY);
    }
}
