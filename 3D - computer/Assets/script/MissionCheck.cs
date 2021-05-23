﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MissionCheck : MonoBehaviour
{
    public int serveItem;
    public int mainItem;
    public Text mainobject;
    public Text serveobject;
    public int maingoalpoint;
    public int servegoalpoint;
    public GameObject success;
    public Sceneffect sceneffect;
    public bool[] finish;
    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
        sceneffect.Effect(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (mainItem >= maingoalpoint && serveItem >= servegoalpoint && finish[2] == true)
        {
            finish[2] = false;
            success.SetActive(true);
        }
        if (serveItem >= servegoalpoint && finish[0] == true)
        {
            finish[0] = false;
            sceneffect.Effect(1);
        }
        /*if (mainItem >= maingoalpoint && finish[1] == true)
        {
            finish[1] = false;
            sceneffect.Effect(2);
        }*/
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "ServeItem")
        {
            serveItem++;
            UpdateUI();
        }
        if (col.collider.tag == "ServeItem") Destroy(col.gameObject);
        if (col.collider.tag == "MainItem")
        {
            mainItem++;
            UpdateUI();
        }
        if (col.collider.tag == "MainItem") Destroy(col.gameObject);
        /*else
        {
            dotDamage = false;
        }*/
    }
    public void UpdateUI()
    {
        mainobject.text = string.Format("{0}/{1}", mainItem, maingoalpoint);
        serveobject.text = string.Format("{0}/{1}", serveItem, servegoalpoint);
    }
}