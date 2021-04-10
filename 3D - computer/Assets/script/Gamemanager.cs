using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int Money;   
    public Text Money_UI = null;
    // Start is called before the first frame update
    void Start()
    {
        Money_UI.text = string.Format("Money : {0}", Money);
    }
    public void UI_Update()
    {
        Money_UI.text = string.Format("Money : {0}", Money);
    }
    public void GetMoney(int Get)
    {
        Money += Get;
        UI_Update();
    }
    public void die()
    {

    }
}
