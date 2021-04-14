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
    //public RectTransform PetStore;

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
        if (Money >= 100)
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
        if (Money >= 500)
        {
            GameManager.GetMoney(100);
            UI_Update();
            Destroy(Revolver);
        }
    }
    public void upgrade3()
    {
        if (Money >= 1000)
        {
            GameManager.GetMoney(-Price[2]);
            UI_Update();
            Destroy(SMG);
        }
    }
    public void upgrade4()
    {
        if (Money >= 4500)
        {
            GameManager.GetMoney(-Price[3]);
            UI_Update();
            Destroy(Asultrifle);
        }
    }
    public void upgrade5()
    {
        if (Money >= 10000)
        {
            GameManager.GetMoney(-Price[4]);
            UI_Update();
            Destroy(Battelrifle);
        }
    }
    public void upgrade6()
    {
        if (Money >= 20000)
        {
            GameManager.GetMoney(-Price[5]);
            UI_Update();
            Destroy(DMR);
        }
    }
    public void upgrade7()
    {
        if (Money >= 30000)
        {
            GameManager.GetMoney(-Price[6]);
            UI_Update();
            Destroy(SR);
        }
    }
    public void upgrade8()
    {
        if (Money >= 45000)
        {
            GameManager.GetMoney(-Price[7]);
            UI_Update();
            Destroy(Lmg);
        }
    }
    /*public void AutoUpGrade1()
    {
        if (Price > 100)
        {
            Destroy(Drone);
        }
    }
    public void AutoUpGrade2()
    {
        if (Price > 1000)
        {
            Destroy(GrounDrone);
        }
    }
    public void AutoUpGrade3()
    {
        if (Price > 10000)
        {
            Destroy(Helii);
        }
    }
    public void AutoUpGrade4()
    {
        if (Price > 100000)
        {
            Destroy(Jet);
        }
    }
    public void AutoUpGrade5()
    {
        if (Price > 1000000)
        {
            Destroy(Mortal);
        }
    }
    public void AutoUpGrade6()
    {
        if (Price > 10000000)
        {
            Destroy(artillery);
        }
    }*/
    public void UI_Update()
    {
        Money_UI.text = string.Format("Money : {0}", Money);
    }
}
