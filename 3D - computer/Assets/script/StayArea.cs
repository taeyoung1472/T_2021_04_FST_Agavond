using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayArea : MonoBehaviour
{
    public bool a = false;
    private void OnCollisionEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            a = true;
        }
    }
}
