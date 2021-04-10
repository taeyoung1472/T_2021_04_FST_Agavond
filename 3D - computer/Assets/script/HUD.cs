using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text scriptTXT;

    public int curammo = 10;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        scriptTXT.text = string.Format("{0}", curammo);
    }
    //private void Awake()
    //{
    //    int curammo = GameObject.Find("Player").GetComponent<GunController>().cur_ammo;
    //}
}
