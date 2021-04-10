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
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1f / deltaTime;
        FPStext.text = fps.ToString();
    }
}
