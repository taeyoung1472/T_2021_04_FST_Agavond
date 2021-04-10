using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    //총관련
    public string PetName;
    public int damage;
    public float RPM;
    public int curammo;
    public int magammo;
    public float ShootDelay;
    public float ReloadTime;
    public bool isFire = true;

    //총 관련 오디오
    public AudioSource[] arrayAudio;

    RaycastHit hit;

    float Range = 200f;

    private void Awake()
    {
        //Shoot = GetComponent<AudioSource>();
        //Empty = GetComponent<AudioSource>();
        arrayAudio = GameObject.Find("PetSound").GetComponents<AudioSource>();

    }
    // Start is called before the first frame update
    void Start()
    {
        curammo = magammo;
    }

    // Update is called once per frame
    void Update()//if (Input.GetKeyDown(KeyCode.Mouse0))
    {
        ShootDelay += Time.deltaTime;
        if (ShootDelay > RPM)//총쏘기 판단
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
    }
    public IEnumerator Reload()
    {
        isFire = false;
        yield return new WaitForSeconds(ReloadTime);
        isFire = true;
    }
    void fire()
    {
        arrayAudio[0].Play();
        ShootDelay = 0f;
        Debug.DrawRay(transform.position, transform.forward * Range, Color.yellow, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, Range))
        {
            if (hit.transform.GetComponent<enemy>())
            {
                hit.transform.GetComponent<enemy>().hp -= damage;
                //arrayAudio[5].Play();
            }
            hit.transform.GetComponent<wall>().Hit_Count++;

        }
    }
    void empty()
    {
        arrayAudio[1].Play();
    }
}
