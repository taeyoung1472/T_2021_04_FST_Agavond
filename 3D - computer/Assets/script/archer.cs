using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archer : MonoBehaviour
{
    public int Bulletspeed;
    public float abilityDelay;
    public float cooltime;
    public int damdage;
    private enemy enemy;
    public Vector3 targetPos;

    public GameObject Bullet;
    public GameObject FirePos;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<enemy>();
    }
    private void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        abilityDelay += Time.deltaTime;

        if (cooltime < abilityDelay)
        {
            fire();
            abilityDelay = 0f;
        }
    }
    void fire()
    {
        targetPos = new Vector3(enemy.target.position.x, enemy.target.position.y - 1f, enemy.target.position.z);
        Instantiate(Bullet, targetPos,FirePos.transform.rotation);
    }
}
