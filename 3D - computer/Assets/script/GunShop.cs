using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShop : MonoBehaviour
{
    //public Text Money_UI;
    private Gamemanager GameManager;
    public RectTransform GunStore;
    public int high;
    //public int Money;
    //private int[] Price = {100,500,1000,4500,10000,20000,30000,45000};
    //private money money;
    //public RectTransform PetStore;

    /*public GameObject Pistole;
    public GameObject Revolver;
    public GameObject SMG;
    public GameObject Asultrifle;
    public GameObject Battelrifle;
    public GameObject DMR;
    public GameObject SR;
    public GameObject Lmg;*/

    /*public GameObject Drone;
    public GameObject GrounDrone;
    public GameObject Helii;
    public GameObject Jet;
    public GameObject Mortal;
    public GameObject artillery;*/
    private void Start()
    {
        GameManager = FindObjectOfType<Gamemanager>();
        //Money = FindObjectOfType<Gamemanager>().Money;
        //money.UI_Update(Money);
        //GameManager.UI_Update();
    }
    /*private void Update()
    {
        Money = FindObjectOfType<Gamemanager>().Money;
        //GameManager.UI_Update();
    }*/
    public void Enter()
    {
        GunStore.anchoredPosition = Vector3.zero;
    }

    public void Exit()
    {
        GunStore.anchoredPosition = Vector3.down * high;
    }
    public void choice0()
    {
        GameManager.upgradeGun(0);
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
    public void choice9()
    {
        GameManager.upgradeGun(9);
    }
    //-----------------------------------------------------------//
    public void TurretChoice1()
    {
        GameManager.upgradeTurret(0);
    }
    public void TurretChoice2()
    {
        GameManager.upgradeTurret(1);
    }
    public void TurretChoice3()
    {
        GameManager.upgradeTurret(2);
    }
    public void TurretChoice4()
    {
        GameManager.upgradeTurret(3);
    }
    public void TurretChoice5()
    {
        GameManager.upgradeTurret(4);
    }
    //-----------------------------------------------------------//
    public void CannonChoice1()
    {
        GameManager.upgradeCannon(0);
    }
    public void CannonChoice2()
    {
        GameManager.upgradeCannon(1);
    }
    public void CannonChoice3()
    {
        GameManager.upgradeCannon(2);
    }
}
