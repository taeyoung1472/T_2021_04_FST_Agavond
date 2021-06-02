using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGameManager : MonoBehaviour
{
    public GameObject player;

    private GUN gun;
    void Start()
    {
        gun = FindObjectOfType<GUN>();
    }

    public void GameSave()
    {
        PlayerPrefs.SetInt("GunArr", gun.arr);
        PlayerPrefs.Save();
        Debug.Log("저장 완료!");
    }

    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("GunArr"))
            return;
        int arr = PlayerPrefs.GetInt("GunArr");

        gun.arr = arr;
    }
}
