using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    public GameObject btn;
    public bool istouch;
    public bool isuse;
    public bool isclose;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        btn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            btn.SetActive(true);
        }
    }
    public void Use()
    {
        btn.SetActive(false);
        panel.SetActive(true);
    }
    public void exit()
    {
        panel.SetActive(false);
    }
}
