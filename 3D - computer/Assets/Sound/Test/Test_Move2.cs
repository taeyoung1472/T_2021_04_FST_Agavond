
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Test_Move2 : MonoBehaviour
{
    Rigidbody rb;
    float power = 30f;
    private Test_Move test_Move;
    private void Awake()
    {
        test_Move = GetComponent<Test_Move>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        test_Move.MoveTo(new Vector3(x, 0, z));
    }
}