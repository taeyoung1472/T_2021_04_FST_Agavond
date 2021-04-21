﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float hp = 100;
    public Text UI_HP;
    public AudioSource[] arrayAudio;
    public bool dotDamage;
    public int Range;
    RaycastHit hit;
    public Slider HP_Value;
    public float ShootDelay;
    public float RPM;
    public Gamemanager gamemanager;

    void Start()
    {
        gamemanager = FindObjectOfType<Gamemanager>();
        arrayAudio = GameObject.Find("Sound").GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //GetMoney = GameObject.FindWithTag("enemy").GetComponent<enemy>().PlayerMoney;
        //money += GetMoney;
        ShootDelay += Time.deltaTime;
        if (ShootDelay > RPM)
        {
               fire();
        }
        if (hp > 100)
        {
            hp = 100;
        }
        if (hp <= 0)
        {
            //Destroy(gameObject);
            gamemanager.die();
            SceneManager.LoadScene("Main");
        }
        UI_HP.text = string.Format("{0}", hp);
        HP_Value.value = hp / 100;
    }

    private void Awake()
    {
        //GetPoint = GameObject.FindWithTag("enemy").GetComponent<enemy>().Point;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "enemy") Destroy(col.gameObject);
        if (col.collider.tag == "Item") Destroy(col.gameObject);
        if (col.collider.tag == "enemy bullet") Destroy(col.gameObject);
        if (col.collider.tag == "enemy")
        {
            damage();
        }
        if (col.collider.tag == "Item")
        {
            heal();
        }
        if (col.collider.tag == "enemy bullet")
        {
            damage();
        }
        else
        {
            dotDamage = false;
        }
    }
    void damage()
    {
        arrayAudio[4].Play();
        hp = hp - 20;
    }
    void heal()
    {
        arrayAudio[3].Play();
        hp = hp + 40;
    }
    void fire()
    {
        Debug.DrawRay(transform.position, new Vector3(0,-3,0) * Range, Color.yellow, 2f);
        if (Physics.Raycast(transform.position, new Vector3(0, -3, 0), out hit, Range))
        {
            ShootDelay = 0;
            if (hit.transform.CompareTag("NEWCLEAR"))
            {
                hp--;
            }
        }
    }
    /*IEnumerator Dot()
    {
        while (dotDamage == true)
        {
            hp--;
            yield return new WaitForSeconds(2.0f);
        }
    }*/
}
