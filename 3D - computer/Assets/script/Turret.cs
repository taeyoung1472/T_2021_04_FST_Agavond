using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    //총관련
    public int[] damage = { 1, 1, 1, 1, 1, 1 };
    public float[] RPM = { 1, 1, 1, 1, 1, 1 };
    public int arr;
    public GameObject Bullet;
    public Transform FirePos;

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
        StartCoroutine(Shoot());
    }
    private IEnumerator Shoot()
    {
        while (true)
        {
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
            arrayAudio[0].Play();
            yield return new WaitForSeconds(RPM[arr]);
        }
    }
}
