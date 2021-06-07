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
    public bool dotDamage;
    //public int Range;
    RaycastHit hit;
    public Slider HP_Value;
    public Slider HP_Back;
    public float ShootDelay;
    public float RPM;
    public Gamemanager gamemanager;
    //public int serveItem;
    //public int mainItem;
    /*public Text mainobject;
    public Text serveobject;
    public int maingoalpoint;
    public int servegoalpoint;
    public GameObject success;*/
    void Start()
    {
        StartCoroutine(HP_Update());
        gamemanager = FindObjectOfType<Gamemanager>();
        arrayAudio = GameObject.Find("Sound").GetComponents<AudioSource>();
        //UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        //GetMoney = GameObject.FindWithTag("enemy").GetComponent<enemy>().PlayerMoney;
        //money += GetMoney;
        /*ShootDelay += Time.deltaTime;
        if (ShootDelay > RPM)
        {
            fire();
        }*/
        if (hp > 100)
        {
            hp = 100;
            StartCoroutine(HP_Update());
        }
        if (hp <= 0)
        {
            //Destroy(gameObject);
            //gamemanager.die();
            SceneManager.LoadScene("Main");
        }
        //if (mainItem >= maingoalpoint && serveItem >= servegoalpoint)
        //    success.SetActive(true);
    }
    /*private void Awake()
    {
        //GetPoint = GameObject.FindWithTag("enemy").GetComponent<enemy>().Point;
    }*/

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "enemy") Destroy(col.gameObject);
        if (col.collider.tag == "Item") Destroy(col.gameObject);
        if (col.collider.tag == "enemy bullet") Destroy(col.gameObject);
        if (col.collider.tag == "enemy")
        {
            damage(20);
        }
        if (col.collider.tag == "Item")
        {
            heal();
        }
        if (col.collider.tag == "enemy bullet")
        {
            damage(20);
        }
        if (col.collider.tag == "Explosion")
        {
            damage(col.gameObject.GetComponent<Explosion_Effect>().damdage);
        }
        /*if (col.collider.tag == "ServeItem")
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
        else
        {
            dotDamage = false;
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Explosion")
        {
            damage(other.gameObject.GetComponent<Explosion_Effect>().damdage);
        }
    }
    void damage(float damage)
    {
        arrayAudio[4].Play();
        hp = hp - damage;
        StartCoroutine(HP_Update());
    }
    void heal()
    {
        arrayAudio[3].Play();
        hp = hp + 40;
        StartCoroutine(HP_Update());
    }
    /*void fire()
    {
        Debug.DrawRay(transform.position, new Vector3(0, -3, 0) * Range, Color.yellow, 2f);
        if (Physics.Raycast(transform.position, new Vector3(0, -3, 0), out hit, Range))
        {
            ShootDelay = 0;
            if (hit.transform.CompareTag("NEWCLEAR"))
            {
                hp--;
                StartCoroutine(HP_Update());
            }
        }
    }*/
    private IEnumerator HP_Update()
    {
        UI_HP.text = string.Format("{0}", hp);
        HP_Value.value = hp / 100;
        yield return new WaitForSeconds(1f);
        HP_Back.value = hp / 100;
    }
    /*IEnumerator Dot()
    {
        while (dotDamage == true)
        {
            hp--;
            yield return new WaitForSeconds(2.0f);
        }
    }*/
    /*void UpdateUI()
    {
        mainobject.text = string.Format("{0}/{1}", mainItem, maingoalpoint);
        serveobject.text = string.Format("{0}/{1}", serveItem, servegoalpoint);
    }*/
    /*public void Timerend()
    {
        UpdateUI();
    }*/
}
