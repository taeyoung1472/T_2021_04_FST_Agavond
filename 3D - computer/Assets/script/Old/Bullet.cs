using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Bulletspeed = 35f;
    public int damdage;

    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Bulletspeed);
    }
}
