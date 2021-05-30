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
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private float[] reboundY = { -1f, -1f, -1f, -1f, -1f, -1f, -1f, -1f, -1f };
    [SerializeField]
    private float[] reboundX = { 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f };
    public float rebound_totalZ;
    public Transform player;
    public TouchRotation touchRotation;
    public float zoom;
    [SerializeField]
    private float[] zoomSize = { 2f, 2f, 2f, 2f, 2f, 2f, 2f, 2f, 2f };
    //public int[] gunMod = { 1, 2, 3 };
    //public int modArr;
    //RaycastHit hit;

    float Range = 200f;

    public Button btnZoom;

    private void Awake()
    {
        //Shoot = GetComponent<AudioSource>();
        //Empty = GetComponent<AudioSource>();
        arrayAudio = GameObject.Find("Sound").GetComponents<AudioSource>();
    }
    // Start is called before the first frame update
    private bool isZoom = false;
    void Start()
    {
        //이 버튼을 클릭시 Zoom함수가 실행
        btnZoom.onClick.AddListener(Zoom);

        //touchRotation.lookInput.x = a;
        //touchRotation.lookInput.y = b;
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
                camera.fieldOfView = 65 / zoom;
                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                rebound_totalZ = Random.Range(-reboundX[arr], reboundX[arr]);
                touchRotation.rebound(reboundY[arr],rebound_totalZ);
                /*rebound_totalY += reboundY;
                rebound_totalZ += Random.Range(-reboundX, reboundX);
                rebound_totalY = Mathf.Clamp(rebound_totalY, -20 - a, 20 + a);*/
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
                            camera.fieldOfView = 60 / zoom;
            //ReboundReturn();
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
    /*private void ReboundReturn()
    {
        camera.transform.localRotation = Quaternion.Euler(rebound_totalY + a,rebound_totalZ, 0);
        if (rebound_totalY <= a)
        {
            rebound_totalY += 0.5f;
        }
        if (rebound_totalZ <= 0)
        {
            rebound_totalZ += 0.25f;
        }
        if (rebound_totalZ >= 0)
        {
            rebound_totalZ -= 0.25f;
        }
    }*/
    public void Zoom()
    {
        if (!isZoom)
        {
            zoom = zoomSize[arr];
        }else
        {
            zoom = 1;
        }
        isZoom = !isZoom;
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