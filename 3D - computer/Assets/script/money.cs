﻿using System.Collections;
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
        UI_Money.text = string.Format("{0}", Money);
    }
    void Update()
    {

    }
    public void UI_Update(int money)
    {
        UI_Money.text = string.Format("{0}", money);
    }
}
