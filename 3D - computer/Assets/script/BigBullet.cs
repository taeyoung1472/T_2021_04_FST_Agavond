using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBullet : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter(Collision col)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
