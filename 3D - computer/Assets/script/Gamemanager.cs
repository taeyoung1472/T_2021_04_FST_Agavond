using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int Money;
    public money wallet;
    public Money2 Game_Money; 
    public DontDestroyOnLoad2 main_canvas;
    public int Arr;
    public GUN gun = null;
    public int maxarr = 0;
    //public Text Money_UI;

    /*private void Awake()
    {
        wallet = GameObject.FindObjectOfType<money>();
    }*/
    void Start()
    {
        load();
        wallet.UI_Update(Money);
        //Money_UI.text = string.Format("{0}", Money);
    }
    //public void UI_Update()
    //{
        //Money_UI.text = string.Format("{0}", Money);
    //}
    public void GetMoney(int Get)
    {
        Money += Get;
        wallet.UI_Update(Money);
        Game_Money.UI_Update(Money);
        //UI_Update();
    }
    public void die()
    {
        main_canvas.Die();
    }
    public void load()
    {
        Game_Money = GameObject.FindObjectOfType<Money2>();
        Game_Money.UI_Update(Money);
    }
    public void Update()
    {
        if (wallet == null)
        {
            Debug.Log("돈을 가져옴");
            wallet = GameObject.FindObjectOfType<money>();
            Debug.Log("돈을 적용시킴");
            wallet.UI_Update(Money);
            Debug.Log("성공");
        }
        if (gun == null)
        {
            Debug.Log("총을 가져옴");
            gun = GameObject.FindObjectOfType<GUN>();
            Debug.Log("총 배열을 적용시킴");
            DataController.Instance.SaveGameData();
            Debug.Log("총 데이터 저장 완료");
            gun.pullgun(Arr);
            Debug.Log("성공");
        }
    }
    public void upgradeGun(int cur)
    {
        if (maxarr <= cur)
        {
            maxarr = cur;
        }
        Arr = cur;
    }
    /*public void Gunload()
    {
        if (gun == null)
        {
            Debug.Log("총을 가져옴");
            gun = GameObject.FindObjectOfType<GUN>();
            Debug.Log("총 배열을 적용시킴");
            gun.pullgun(Arr);
            Debug.Log("성공");
        }
    }*/
}
