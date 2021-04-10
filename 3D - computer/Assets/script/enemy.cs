using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public int hp = 100;
    public Transform target;
    public int DropMoney;
    private money Money;

    private Gamemanager gameManager;
    //public int Point;

    NavMeshAgent nav;

    void Awake()
    {
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
            Destroy(gameObject);
            gameManager.GetMoney(DropMoney);
        }
        nav.SetDestination(target.position);
    }
}
