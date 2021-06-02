using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelect : MonoBehaviour
{
    public GameObject[] mapBtn;
    public int arr;
    private void Start()
    {
        for(int i = 0;i < arr; i++)
        {
            mapBtn[i].SetActive(false);
        }
    }
}
