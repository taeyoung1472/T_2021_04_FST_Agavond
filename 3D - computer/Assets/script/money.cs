using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class money : MonoBehaviour
{
    public Text UI_Money;
    public int Money;

    public void Start()
    {
        Money = FindObjectOfType<Gamemanager>().Money;
    }
    void Update()
    {

    }
    public void UI_Update()
    {
        UI_Money.text = string.Format("Money : {0}", Money);
    }
}
