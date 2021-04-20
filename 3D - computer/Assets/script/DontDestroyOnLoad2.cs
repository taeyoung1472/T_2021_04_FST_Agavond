using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad2 : MonoBehaviour
{
    public GameObject Child;
    private void Awake()
    {
        var obj = FindObjectsOfType<DontDestroyOnLoad2>();

        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Change()
    {
        Child.SetActive(false);
    }
    public void Die()
    {
        Child.SetActive(true);
    }
}