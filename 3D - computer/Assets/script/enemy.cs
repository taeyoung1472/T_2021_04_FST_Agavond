    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public int hp = 100;
    public Transform target;
    [SerializeField]
    private MissionCheck mission;

    private Gamemanager gameManager;
    //public int Point;

    NavMeshAgent nav;

    void Awake()
    {
        mission = GameObject.FindWithTag("Player").GetComponent<MissionCheck>();
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    void Start()
    {
        gameManager = FindObjectOfType<Gamemanager>();
    }

    void Update()
    {
        if (hp <= 0)
        {
            mission.Kill();
            Destroy(gameObject);
        }
        nav.SetDestination(target.position);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Bullet")
        {
            hp -= col.gameObject.GetComponent<Bullet>().damdage;
        }
        if (col.collider.tag == "Explosion")
        {
            hp -= 20;
            Debug.Log(hp);
        }
    }
}
