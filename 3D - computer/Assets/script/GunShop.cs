using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShop : MonoBehaviour
{
    public Text Money_UI;
    private Gamemanager GameManager;
    public RectTransform GunStore;
    public int Money;
    private int[] Price = {100,500,1000,4500,10000,20000,30000,45000};
    private money money;
    //public RectTransform PetStore;

    public GameObject[] Gunarr { };
    public GameObject Pistole;
    public GameObject Revolver;
    public GameObject SMG;
    public GameObject Asultrifle;
    public GameObject Battelrifle;
    public GameObject DMR;
    public GameObject SR;
    public GameObject Lmg;

    /*public GameObject Drone;
    public GameObject GrounDrone;
    public GameObject Helii;
    public GameObject Jet;
    public GameObject Mortal;
    public GameObject artillery;*/
    private void Start()
    {
        GameManager = FindObjectOfType<Gamemanager>();
        Money = FindObjectOfType<Gamemanager>().Money;
        money.UI_Update(Money);
        //GameManager.UI_Update();
    }
    private void Update()
    {
        //GameManager.UI_Update();
    }
    public void Enter()
    {
        GunStore.anchoredPosition = Vector3.zero;
    }

    public void Exit()
    {
        GunStore.anchoredPosition = Vector3.down * 2000;
    }
    /*public void UpGradeEnter()
    {
        PetStore.anchoredPosition = Vector3.zero;
    }*/

    /*public void UpGradeExit()
    {
        PetStore.anchoredPosition = Vector3.down * 4000;
    }*/
    public void upgrade1()
    {
        if (Money >= Price[0])
        {
            Debug.Log("업그레이드를 함");
            UI_Update();
            Pistole.SetActive(false);
            GameManager.GetMoney(-Price[0]);
            Debug.Log("니가 드디어 성공함");
        }
        else
            Debug.Log("니가 문갈 잘못함");
    }
    public void upgrade2()
    {
        if (Money >= Price[1])
        {
            UI_Update();
            Revolver.SetActive(false);
            GameManager.GetMoney(-Price[1]);
        }
    }
    public void upgrade3()
    {
        if (Money >= Price[2])
        {
            UI_Update();
            SMG.SetActive(false);
            GameManager.GetMoney(-Price[2]);
        }
    }
    public void upgrade4()
    {
        if (Money >= Price[3])
        {
            UI_Update();
            Asultrifle.SetActive(false);
            GameManager.GetMoney(-Price[3]);
        }
    }
    public void upgrade5()
    {
        if (Money >= Price[4])
        {
            UI_Update();
            Battelrifle.SetActive(false);
            GameManager.GetMoney(-Price[4]);
        }
    }
    public void upgrade6()
    {
        if (Money >= Price[5])
        {
            UI_Update();
            DMR.SetActive(false);
            GameManager.GetMoney(-Price[5]);
        }
    }
    public void upgrade7()
    {
        if (Money >= Price[6])
        {
            UI_Update();
            SR.SetActive(false);
            GameManager.GetMoney(-Price[6]);
        }
    }
    public void upgrade8()
    {
        if (Money >= Price[7])
        {
            UI_Update();
            Lmg.SetActive(false);
            GameManager.GetMoney(-Price[7]);
        }
    }
    public void choice1()
    {
        GameManager.upgradeGun(1);
    }
    public void choice2()
    {
        GameManager.upgradeGun(2);
    }
    public void choice3()
    {
        GameManager.upgradeGun(3);
    }
    public void choice4()
    {
        GameManager.upgradeGun(4);
    }
    public void choice5()
    {
        GameManager.upgradeGun(5);
    }
    public void choice6()
    {
        GameManager.upgradeGun(6);
    }
    public void choice7()
    {
        GameManager.upgradeGun(7);
    }
    public void choice8()
    {
        GameManager.upgradeGun(8);
    }
    public void UI_Update()
    {
        Money_UI.text = string.Format("{0}", Money);
    }
}
