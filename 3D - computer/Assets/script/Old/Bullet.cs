using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Bulletspeed = 100f;
    public int damdage;

    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Bulletspeed);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (col.collider.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
