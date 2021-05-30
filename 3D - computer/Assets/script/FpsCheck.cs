using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsCheck : MonoBehaviour
{
    float deltaTime = 0f;
    public Text FPStext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FpsCheckcol());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator FpsCheckcol()
    {
        while (true)
        {
            deltaTime += (Time.deltaTime - deltaTime) * 1f;
            float fps = 1f / deltaTime;
            FPStext.text = fps.ToString();
            yield return new WaitForSeconds(0.3f);
        }
    }
}
