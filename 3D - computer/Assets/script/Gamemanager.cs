using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int gunArr;
    public int turretArr;
    public int cannonArr;
    public GUN gun;
    public TurretManager turret;
    public Cannon cannon;
    public void Start()
    {
        LoadCannonData();
        LoadGunData();
        LoadTurretData();
        SaveData();
    }
    public void Update()
    {
        if (gun == null)
        {
            gun = GameObject.FindObjectOfType<GUN>();
        }
        else
            gun.pullgun(gunArr);
        if (turret == null)
        {
            turret = GameObject.FindObjectOfType<TurretManager>();
        }
        else
            turret.pullturret(turretArr);
        if (cannon == null)
        {
            cannon = GameObject.FindObjectOfType<Cannon>();
        }
        else
            cannon.pullcannon(cannonArr);
    }
    public void upgradeGun(int cur)
    {
        gunArr = cur;
    }
    public void upgradeTurret(int cur)
    {
        turretArr = cur;
    }
    public void upgradeCannon(int cur)
    {
        cannonArr = cur;
    }
    public void SaveData()
    {
        PlayerPrefs.SetInt("GunArr", gunArr);
        PlayerPrefs.SetInt("TurretArr", turretArr);
        PlayerPrefs.SetInt("CannonArr", cannonArr);
        PlayerPrefs.Save();
    }
    public void LoadGunData()
    {
        if (PlayerPrefs.HasKey("GunArr"))
            //return;
        gunArr = PlayerPrefs.GetInt("GunArr");
    }
    public void LoadTurretData()
    {
        if (PlayerPrefs.HasKey("TurretArr"))
            //return;
        turretArr = PlayerPrefs.GetInt("TurretArr");
    }
    public void LoadCannonData()
    {
        if (PlayerPrefs.HasKey("CannonArr"))
            //return;
        cannonArr = PlayerPrefs.GetInt("CannonArr");
    }
    public void OnApplicationQuit()
    {
        SaveData();
        Debug.LogError("게임 종료");
    }
}
/*
public class Gamemanager : MonoBehaviour
{
    public void Start()
    {
        LoadData();
        SaveData();
    }
    public void Update()
    {
        Debug.LogError(gunArr);
        if (gun == null)
        {
            gun = GameObject.FindObjectOfType<GUN>();
            //gun.pullgun(gunArr);
        }
        if (turret == null)
        {
            turret = GameObject.FindObjectOfType<TurretManager>();
            //turret.pullturret(turretArr);
        }
        if (cannon == null)
        {
            cannon = GameObject.FindObjectOfType<Cannon>();
            //cannon.pullcannon(cannonArr);
        }
    }
    public void upgradeGun(int cur)
    {
        gunArr = cur;
        SaveData();
    }
    public void upgradeTurret(int cur)
    {
        turretArr = cur;
    }
    public void upgradeCannon(int cur)
    {
        cannonArr = cur;
    }
    public void SaveData()
    {
        PlayerPrefs.SetInt("GunArr", gunArr);
        PlayerPrefs.SetInt("TurretArr", turretArr);
        PlayerPrefs.SetInt("CannonArr", cannonArr);
        PlayerPrefs.Save();
    }
    public void LoadGunData()
    {
        if (PlayerPrefs.HasKey("GunArr"))
            return;
        gunArr = PlayerPrefs.GetInt("GunArr");
    }
    public void LoadTurretData()
    {
        if (PlayerPrefs.HasKey("TurretArr"))
            return;
        turretArr = PlayerPrefs.GetInt("TurretArr");
    }
    public void LoadCannonData()
    {
        if (PlayerPrefs.HasKey("CannonArr"))
            return;
        cannonArr = PlayerPrefs.GetInt("CannonArr");
    }
    public void OnApplicationQuit()
    {
        SaveData();
        Debug.LogError("게임 종료");
    }
}*/