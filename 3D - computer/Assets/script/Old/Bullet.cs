using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Bulletspeed = 100f;
    public int damdage;

    private void Start()
    {
        StartCoroutine(Destroy());
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Bulletspeed * Time.deltaTime);
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
