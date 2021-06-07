using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPoint : MonoBehaviour
{
    public MissionCheck mission;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            mission.serveItem++;
            mission.UpdateUI();
            Destroy(collision.gameObject);
        }
    }
}
