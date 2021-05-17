using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_zoom : MonoBehaviour
{
    private Vector3 defalt;//0,1.15,0
    private Vector3 zoomPos;
    // Start is called before the first frame update
    void Start()
    {
        defalt = transform.position;
        zoomPos = new Vector3(0, 0.85f, 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.position = zoomPos;
        }
        //else
        //    transform.position = defalt;
    }
}
