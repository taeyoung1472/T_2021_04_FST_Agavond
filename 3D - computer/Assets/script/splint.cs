using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splint : MonoBehaviour
{
    public int speed;
    public float abilityDelay;
    public float cooltime;
    public float abilitytime;
    public float abilitytimeDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        abilityDelay += Time.deltaTime;

        if (cooltime < abilityDelay)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            abilitytimeDelay += Time.deltaTime;
            if(abilitytimeDelay > abilitytime)
            {
                abilityDelay = 0f;
                abilitytimeDelay = 0f;
            }
        }
    }
}
