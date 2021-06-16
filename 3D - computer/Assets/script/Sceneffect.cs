using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneffect : MonoBehaviour
{
    public Camera[] scene;
    public int[] time;
    public bool isOff;
    public void Effect(int num)
    {
        if(isOff == false)
        {
            StartCoroutine(Effectcoru(num));
        }
    }
    public IEnumerator Effectcoru(int num)
    {
        Time.timeScale = 0;
        scene[num].gameObject.SetActive(true);
        yield return new WaitForSeconds(time[num]);
        scene[num].gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}