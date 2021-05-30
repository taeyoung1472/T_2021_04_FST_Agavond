using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float cooltime;
    private enemy enemy;
    public Vector3 targetPos;
    public GameObject target;

    public GameObject Bullet;
    public GameObject FirePos;
    void fire()
    {
        targetPos = new Vector3(target.transform.position.x, target.transform.position.y-1, target.transform.position.z);
        Instantiate(Bullet, targetPos, FirePos.transform.rotation);
    }
    private IEnumerator Use()
    {
        for (int i = 0;i < 10; i++)
        {
            target = FindObjectOfType<enemy>().gameObject;
            fire();
            yield return new WaitForSeconds(cooltime);
        }
    }
    public void BtnDown()
    {
        StartCoroutine(Use());
    }
}
