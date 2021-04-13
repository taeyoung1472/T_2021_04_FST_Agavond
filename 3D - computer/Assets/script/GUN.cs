using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUN : MonoBehaviour
{
    //총관련
    private string[] GunName = {"M1911", "PL15", "더블액션 리볼버", "MP5", "AK74", "SA58", "SVD", "M24", "M249"};
    private int[] damage = { 20, 35, 100, 30, 40, 60, 100, 200, 40 };
    private float[] RPM = { 0.2f, 0.15f, 1f, 0.067f, 0.1f, 0.12f, 0.5f, 2f, 0.075f };
    public int curammo;
    private int[] magammo = { 7, 15, 6, 30, 30, 20, 10, 5, 99 };
    public float ShootDelay;
    //public float[] ReloadTime = { "M1911", "PL15", "더블액션 리볼버", "MP5", "AK74", "SA58", "SVD", "M24", "M249" };
    public float ReloadTime;
    public bool isFire = true;
    public int arr;
    //총 관련 UI
    public Text HUD;
    public Text UI_GunName;
    //총 관련 오디오
    public AudioSource[] arrayAudio;    
    
    RaycastHit hit;

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
        curammo = magammo[arr];
    }

    // Update is called once per frame
    void Update()
    {
        ShootDelay += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0) && ShootDelay > RPM[arr])//총쏘기 판단
        {
            if (isFire == true)
            {
                if (curammo > 0)
                {
                    fire();
                }
                else
                {
                    empty();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R))//장전
        {
            arrayAudio[2].Play();
            StartCoroutine("Reload");
        }
        HUD.text = string.Format("{0} / {1}", curammo, magammo[arr]);
        UI_GunName.text = string.Format("{0}", GunName[arr]);
    }
    public IEnumerator Reload()
    {
        isFire = false;
        yield return new WaitForSeconds(ReloadTime);
        isFire = true;
        curammo = magammo[arr];
    }
    void fire()
    {
        curammo--;

        arrayAudio[0].Play();
        ShootDelay = 0f;
        Debug.DrawRay(transform.position, transform.forward * Range, Color.yellow, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, Range))
        {
            if (hit.transform.GetComponent<enemy>())
            {
                hit.transform.GetComponent<enemy>().hp -= damage[arr];
                arrayAudio[5].Play();
            }
            hit.transform.GetComponent<wall>().Hit_Count++;
            
        }
    }
    void empty()
    {
        arrayAudio[1].Play();
    }
}
