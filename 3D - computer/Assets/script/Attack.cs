using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    public bool isattack;
    public float cooltime;
    public float speed;
    public float timer;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime * speed;
        if(timer >= cooltime && isattack == true)
        {
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
            timer = 0;
        }
    }
    public void ButtonAttack()
    {
        isattack = true;
    }
    public void OutButtonAttack()
    {
        isattack = false;
    }
}
