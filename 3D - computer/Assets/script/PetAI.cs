using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class PetAI : MonoBehaviour
{
    public Transform enemytarget;
    //NavMeshAgent enemynav;
    /*void Awake()
    {
        //enemynav = GetComponent<NavMeshAgent>();
    }*/

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(enemytarget);
        enemytarget = GameObject.FindWithTag("enemy").GetComponent<Transform>();
    }
}
