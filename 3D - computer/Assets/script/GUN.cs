using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUN : MonoBehaviour
{
    //총관련
    private string[] GunName = {"M1911", "PL15", "Revolver", "MP5", "AK74", "SA58", "SVD", "M24", "M249"};
    //private int[] damage = { 20, 35, 100, 30, 40, 60, 100, 200, 40 };
    private float[] RPM = { 0.2f, 0.15f, 1f, 0.067f, 0.1f, 0.12f, 0.5f, 2f, 0.075f };
    public int curammo;
    private int[] magammo = { 7, 15, 6, 30, 30, 20, 10, 5, 99 };
    public float ShootDelay;
    //public float[] ReloadTime = { "M1911", "PL15", "더블액션 리볼버", "MP5", "AK74", "SA58", "SVD", "M24", "M249" };
    public float ReloadTime;
    public bool isFire = true;
    public int arr;
    public bool Fire;
    public GameObject Bullet;
    public Transform FirePos;
    public bool istick;
    //총 관련 UI
    public Text HUD;
    public Text UI_GunName;
    //총 관련 오디오
    public AudioSource[] arrayAudio;
    //public int[] gunMod = { 1, 2, 3 };
    //public int modArr;
    //RaycastHit hit;

    float Range = 200f;

    private void Awake()
    {
        //Shoot = GetComponent<AudioSource>();
        //Empty = GetComponent<AudioSource>();
        arrayAudio = GameObject.Find("Sound").GetComponents<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //if (arr == 2 || arr == 7 || arr == 6)
        ///    modArr = 0;
        //else
        //    modArr = 1;
        StartCoroutine(Reload());
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator Reload()
    {
        arrayAudio[2].Play();
        isFire = false;
        yield return new WaitForSeconds(ReloadTime);
        isFire = true;
        curammo = magammo[arr];
        HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);
    }
    private IEnumerator Shoot()
    {
        while(true)
        {
            if (Fire == true && curammo >= 1)
            {
                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                arrayAudio[0].Play();
                curammo--;
                HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);
                istick = true;
            }
            if (Fire == true && curammo == 0 && istick == true)
            {
                istick = false;
                arrayAudio[1].Play();
            }
            yield return new WaitForSeconds(RPM[arr]);
        }
        /*while (gunMod[modArr] == 2)
        {
            if (Fire == true && curammo >= 1)
            {
                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                arrayAudio[0].Play();
                curammo--;
                HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);
                istick = true;
            }
            if(Fire == true && curammo == 0 && istick == true)
            {
                istick = false;
                arrayAudio[1].Play();
            }
            yield return new WaitForSeconds(RPM[arr]);
        }*/
    }
    void empty()
    {
        arrayAudio[1].Play();
    }
    public void pullgun(int gun)
    {
        arr = gun;
    }
    public void ButtonShoot()
    {
        //if (gunMod[modArr] == 1)
        //{
            Fire = true;
        //    StartCoroutine(Shoot());
        //}
        //if (gunMod[modArr] == 2)
        //{
        ///    Fire = true;
        //}
        //Fire = true;
    }
    public void ButtonShootStop()
    {
        Fire = false;
    }
    public void reroad()
    {
       StartCoroutine("Reload");
    }
    /*public void Shoot()
    {
        if (curammo > 0 && ShootDelay > RPM[arr])
        {
            fire();
        }
        else
        {
            empty();
        }
        HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);
        UI_GunName.text = string.Format("{0}", GunName[arr]);
    }*/
}
        /*ShootDelay = 0f;
        Debug.DrawRay(transform.position, transform.forward * Range, Color.yellow, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, Range))
        {
            if (hit.transform.GetComponent<enemy>())
            {
                hit.transform.GetComponent<enemy>().hp -= damage[arr];
                arrayAudio[5].Play();
            }
            hit.transform.GetComponent<wall>().Hit_Count++;
            
        }*/