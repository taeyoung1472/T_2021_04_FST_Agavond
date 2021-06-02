using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Boss1 : MonoBehaviour
{
    public int hp = 100;
    public Transform target;

    private Gamemanager gameManager;
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
        }
        nav.SetDestination(target.position);
    }
}
