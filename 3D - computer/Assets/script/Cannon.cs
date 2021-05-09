using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public int Bulletspeed;
    public float abilityDelay;
    public float cooltime;
    public int damdage;
    private enemy enemy;
    public Vector3 targetPos;
    public GameObject target;

    public GameObject Bullet;
    public GameObject FirePos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Use());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SearchTarget()
    {
        target = FindObjectOfType<enemy>().gameObject;
    }
    void fire()
    {
        targetPos = new Vector3(enemy.target.position.x, enemy.target.position.y - 1f, enemy.target.position.z);
        Instantiate(Bullet, targetPos, FirePos.transform.rotation);
    }
    private IEnumerator Use()
    {
        for(int i = 0;i < 5; i++)
        {
            SearchTarget();
            fire();
            yield return new WaitForSeconds(2.5f);
        }
    }
}
