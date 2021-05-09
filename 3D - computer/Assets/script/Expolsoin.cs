using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expolsoin : MonoBehaviour
{
    public float size;
    public float maxsize;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (size < maxsize)
        {
            size += Time.deltaTime * speed;
            transform.localScale = new Vector3(size, 0.01f, size);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
