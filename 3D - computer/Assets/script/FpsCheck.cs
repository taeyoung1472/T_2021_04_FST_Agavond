using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsCheck : MonoBehaviour
{
    float deltaTime = 0f;
    public Text FPStext;
    public Image image;
    void Start()
    {
        StartCoroutine(FpsCheckcol());
    }
    private IEnumerator FpsCheckcol()
    {
        while (true)
        {
            deltaTime += (Time.deltaTime - deltaTime) * 1f;
            float fps = Mathf.Round(1 / Time.deltaTime);
            FPStext.text = string.Format("FPS:{0}", fps);
            if (fps <= 15)
            {
                image.color = Color.red;
            }
            else if (fps <= 30)
            {
                image.color = Color.yellow;
            }
            else
                image.color = Color.green;
            yield return new WaitForSeconds(0.3f);
        }
    }
}
