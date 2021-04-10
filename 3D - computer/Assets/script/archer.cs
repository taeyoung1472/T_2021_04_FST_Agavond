using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archer : MonoBehaviour
{
    public int Bulletspeed;
    public float abilityDelay;
    public float cooltime;
    public int damdage;
    public GameObject cube;

    public GameObject Bullet;
    public GameObject FirePos;
    // Start is called before the first frame update
    void Start()
    {

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
        Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
    }
}
