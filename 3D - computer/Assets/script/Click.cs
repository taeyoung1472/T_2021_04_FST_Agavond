using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource[] audioSources;
    public void Click1()
    {
        audioSources[0].Play();
    }
    public void Click2()
    {
        audioSources[1].Play();
    }
}
