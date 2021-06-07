using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneffect : MonoBehaviour
{
    public Camera[] scene;
    public int[] time;
    public void Effect(int num)
    {
        StartCoroutine(Effectcoru(num));
    }
    public IEnumerator Effectcoru(int num)
    {
        scene[num].gameObject.SetActive(true);
        yield return new WaitForSeconds(time[num]);
        scene[num].gameObject.SetActive(false);
    }
}