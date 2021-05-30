using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Effect : MonoBehaviour
{
    public Collider collider;
    public int damdage;
    public AudioSource audiol;
    // Start is called before the first frame update
    void Start()
    {
        audiol.Play();
        StartCoroutine(Destroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collider.enabled = false;
        }
        if (collision.transform.tag == "enemy")
        {
            collider.enabled = false;
        }
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
