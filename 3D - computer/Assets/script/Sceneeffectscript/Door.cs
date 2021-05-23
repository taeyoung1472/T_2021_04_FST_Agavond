using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private float speedx;
    [SerializeField]
    private float speedy;
    [SerializeField]
    private float speedz;
    [SerializeField]
    private float speed;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speedx, speedy, speedz) * speed * Time.deltaTime);
    }
}
