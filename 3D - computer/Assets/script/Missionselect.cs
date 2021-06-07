using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    public GameObject btn;
    public GameObject panel;
    public GameObject panel2;
    void Start()
    {
        btn.SetActive(true);
        panel.SetActive(false);
    }
    public void Use()
    {
        btn.SetActive(false);
        panel2.SetActive(true);
    }
    public void exit()
    {
        panel2.SetActive(false);
        btn.SetActive(true);
    }
}
