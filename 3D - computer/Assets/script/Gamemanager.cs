using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int Money;
    public money wallet;
    //public Text Money_UI;

    /*private void Awake()
    {
        wallet = GameObject.FindObjectOfType<money>();
    }*/
    void Start()
    {
        load();
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
        //UI_Update();
    }
    public void die()
    {

    }
    public void load()
    {
        wallet = GameObject.FindObjectOfType<money>();
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
    }
}
