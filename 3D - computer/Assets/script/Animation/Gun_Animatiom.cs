using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Animatiom : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Shoot()
    {
        while (true)
        {
            animator.Play("Back");
            animator.Play("Slider");
            animator.Play("Grip");
            animator.Play("Trigger");
            yield return new WaitForSeconds(1f);
        }
    }
}
