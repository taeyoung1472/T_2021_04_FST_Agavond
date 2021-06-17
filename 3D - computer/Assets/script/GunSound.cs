using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSound : MonoBehaviour
{
    public AudioSource shoot;
    public AudioSource reload;
    public void Shoot()
    {
        shoot.Play();
    }
    public void Reload()
    {
        reload.Play();
    }
}
