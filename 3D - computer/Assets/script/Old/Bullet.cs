using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Bulletspeed = 100f;
    public int damdage;
    private Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.forward * Bulletspeed);
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
