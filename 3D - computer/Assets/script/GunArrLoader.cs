using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GunArrLoader : MonoBehaviour
{
    public Text UI_Money;
    public int money;
    public int CurArr;

    void Update()
    {
        UI_Money.text = string.Format("Money : {0}", money);
    }
    void Change(int Arr)
    {
        CurArr = Arr;
    }
}

