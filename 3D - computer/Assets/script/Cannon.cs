using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float[] cooltime;
    public int[] fireTime;
    [SerializeField]
    private int arr = -1;
    private enemy enemy;
    public Vector3 targetPos;
    public GameObject target;

    public GameObject[] Bullet;
    public GameObject FirePos;
    public GameObject btn;
    private void Start()
    {
        /*if(arr == -1)
        {
            btn.SetActive(false);
        }*/
    }
    void fire()
    {
        targetPos = new Vector3(target.transform.position.x, target.transform.position.y-1, target.transform.position.z);
        Instantiate(Bullet[arr], targetPos, FirePos.transform.rotation);
    }
    private IEnumerator Use()
    {
        for (int i = 0;i < fireTime[arr]; i++)
        {
            target = FindObjectOfType<enemy>().gameObject;
            fire();
            yield return new WaitForSeconds(cooltime[arr]);
        }
    }
    public void BtnDown()
    {
        StartCoroutine(Use());
    }
    public void pullcannon(int a)
    {
        arr = a;
    }
}
