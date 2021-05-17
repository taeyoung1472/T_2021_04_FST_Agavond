using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Destroy : MonoBehaviour
{
    private bool isGet = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "tool")
        {
            Destroy(collision.gameObject);
            isGet = true;
        }
        if (collision.transform.tag == "Plant"&&isGet == true) Destroy(collision.gameObject);
    }
}
