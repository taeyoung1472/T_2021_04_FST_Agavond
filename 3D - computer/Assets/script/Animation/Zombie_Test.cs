using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Test : MonoBehaviour
{
    public Animator animator;
    public int hp;
    public int damage;
    public int bullet_damage;
    public Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("zombie_attack");
        }*/
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(Dead());
        }*/
    }
    private IEnumerator Dead()
    {
        collider.enabled = false;
        animator.Play("zombie_death_standing");
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Bullet")
        {
            hp -= bullet_damage;
            if(hp <= 0)
            {
                StartCoroutine(Dead());
            }
        }
        if(collision.transform.tag == "Player")
        {
            animator.Play("zombie_attack");
        }
    }
}
