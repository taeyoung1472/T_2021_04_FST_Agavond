using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float hp = 100;
    public Text UI_HP;
    public AudioSource[] arrayAudio;

    // Start is called before the first frame update
    void Start()
    {
        arrayAudio = GameObject.Find("Sound").GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //GetMoney = GameObject.FindWithTag("enemy").GetComponent<enemy>().PlayerMoney;
        //money += GetMoney;
        if (hp > 100)
        {
            hp = 100;
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Main");
        }
        UI_HP.text = string.Format("HP : {0}", hp);
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
}
