using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject Bullet;
    public Transform FirePos;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
    }
}
