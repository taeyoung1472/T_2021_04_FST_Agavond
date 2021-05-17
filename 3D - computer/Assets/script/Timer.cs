using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public MissionCheck missionCheck;
    public GameObject timeUi;
    public Text clock;
    public float Time;
    public bool istake;
    // Start is called before the first frame update
    void Start()
    {
        istake = true;
        missionCheck = FindObjectOfType<MissionCheck>();
        timeUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player" && istake == true)
        {
            istake = false;
            StartCoroutine(OnTimer());
        }
    }
    private IEnumerator OnTimer()
    {
        istake = false;
        timeUi.SetActive(true);
        while (Time >= 1)
        {
            Time -= 1;
            UIupdate();
            yield return new WaitForSeconds(1f);
        }
        missionCheck.mainItem += 1;
        missionCheck.UpdateUI();
        timeUi.SetActive(false);
        Destroy(gameObject);
    }
    void UIupdate()
    {
        clock.text = string.Format("{0}", Time);
    }
}
