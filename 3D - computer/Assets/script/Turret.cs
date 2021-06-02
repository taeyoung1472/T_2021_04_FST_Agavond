using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    private float[] RPM = { 0.10f, 0.15f, 0.2f, 0.7f, 5f, 1};
    public int arr;
    public GameObject Bullet;
    public Transform FirePos;
    public AudioSource[] arrayAudio;
    private void Awake()
    {
        arrayAudio = GameObject.Find("PetSound").GetComponents<AudioSource>();
    }
    private void OnEnable()
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
