using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class GameData
{
    public GUN GUN;
    public int DataGunArr = 0;
    void start()
    {
        GUN.arr = DataGunArr;
    }
}
