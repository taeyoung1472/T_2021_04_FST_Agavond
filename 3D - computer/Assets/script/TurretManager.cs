using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] turret;
    [SerializeField]
    private float[] duration = { 5, 5, 5, 5, 5 };
    [SerializeField]
    private int arr = -1;
    public GameObject btn;
    private void Start()
    {
        /*if (arr == -1)
        {
            btn.SetActive(false);
        }*/
    }
    public void Use()
    {
        StartCoroutine(UseCoru());
    }
    public IEnumerator UseCoru()
    {
        turret[arr].SetActive(true);
        yield return new WaitForSeconds(duration[arr]);
        turret[arr].SetActive(false);
    }
    public void pullturret(int a)
    {
        arr = a;
    }
}