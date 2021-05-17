using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    public GameObject btn;
    public GameObject panel;
    void Start()
    {
        btn.SetActive(true);
        panel.SetActive(false);
    }
    public void Use()
    {
        btn.SetActive(false);
        panel.SetActive(true);
    }
    public void exit()
    {
        panel.SetActive(false);
        btn.SetActive(true);
    }
}
