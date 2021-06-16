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
    public void Update()
    {
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
    }
    public void upgradeTurret(int cur)
    {
        turretArr = cur;
    }
    public void upgradeCannon(int cur)
    {
        cannonArr = cur;
    }
}
