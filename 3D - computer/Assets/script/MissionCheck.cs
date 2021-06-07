using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MissionCheck : MonoBehaviour
{
    public int serveItem;
    public int mainItem;
    public int zombie;
    public Text mainobject;
    public Text serveobject;
    public Text zombietxt;
    public int maingoalpoint;
    public int servegoalpoint;
    public int zombiegoalpoint;
    public GameObject success;
    public Sceneffect sceneffect;
    public bool[] finish;
    public int a;
    public Slider bar;
    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
        sceneffect.Effect(0);
    }

    // Update is called once per frame
    void Update()
    {
        bar.value = a * 0.0003f;
        if(bar.value >= 1)
        {
            finish[2] = true;
        }
        if(finish[0] == true)
        {
            sceneffect.Effect(1);
            if (finish[1] == true)
            {
                sceneffect.Effect(2);
                if (finish[2] == true)
                {
                    sceneffect.Effect(3);
                    if (finish[3] == true)
                    {
                        success.SetActive(true);
                    }
                }
            }
        }
        /*if (mainItem >= maingoalpoint && finish[1] == true)
        {
            finish[1] = false;
            sceneffect.Effect(2);
        }*/
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "ServeItem" && finish[0] == true)
        {
            serveItem++;
            if (serveItem >= servegoalpoint)
                finish[1] = true;
            Destroy(col.gameObject);
            UpdateUI();
        }
        if (col.collider.tag == "MainItem" && finish[2] == true)
        {
            mainItem++;
            if (mainItem >= maingoalpoint)
                finish[3] = true;
            Destroy(col.gameObject);
            UpdateUI();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "StayArea" && finish[1]==true)
        {
            a += 1;
        }
    }
    public void UpdateUI()
    {
        mainobject.text = string.Format("{0}/{1}", mainItem, maingoalpoint);
        serveobject.text = string.Format("{0}/{1}", serveItem, servegoalpoint);
        zombietxt.text = string.Format("{0}/{1}", zombie, zombiegoalpoint);
    }
    public void Back()
    {
        SceneManager.LoadScene("Main");
    }
    public void Kill()
    {
        zombie++;
        if (zombie >= zombiegoalpoint)
            finish[0] = true;
        UpdateUI();
    }
}
