using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Bulletspeed = 100f;
    public int damdage;
    public Rigidbody rigidbody;
    private void Start()
    {
        rigidbody.AddForce(transform.forward * Bulletspeed);
        StartCoroutine(Destroy());
    }
    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
