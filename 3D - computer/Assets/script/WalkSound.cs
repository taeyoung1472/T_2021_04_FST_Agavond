using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSound : MonoBehaviour
{
    public AudioSource[] audio;
    public void walk(int a)
    {
        audio[a].Play();
    }
}
