using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRay : MonoBehaviour
{
    /*private Ray ray;
    private RaycastHit hit;
    public bool btnon;
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fire());
        btn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (btnon == true)
            btn.SetActive(true);
        if (btnon == false)
            btn.SetActive(false);
    }
    /*private IEnumerator fire()근접공격 시스템으로 응용
    {
        while (true)
        {
            Debug.DrawRay(transform.position, transform.forward * 5f, Color.yellow, 0.1f);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
            {
                if (hit.collider.tag == "tool")
                {
                    btnon = true;
                }
            }
               yield return new WaitForSeconds(0.1f);
        }
    }*/
}
