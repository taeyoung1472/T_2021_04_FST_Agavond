using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeStop : MonoBehaviour
{
    public bool isStop;
    public GameObject panel;
    public GameObject main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isStop == true)
        {
            Time.timeScale = 0;
        }
        if(isStop == false)
        {
            Time.timeScale = 1;
        }
    }
    public void Stop()
    {
        isStop = true;
        panel.SetActive(true);
    }
    public void GO()
    {
        isStop = false;
        panel.SetActive(false);
    }
    public void GiveUp()
    {
        SceneManager.LoadScene("Main");
    }
}
