using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class MP4 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private VideoPlayer videoPlayer;
    [SerializeField]
    private GameObject screen;
    public void Use()
    {
        Debug.Log("C");
        StartCoroutine(Play());
        Debug.Log("B");
    }
    private IEnumerator Play()
    {
        Debug.Log("A");
        screen.SetActive(true);
        videoPlayer.Play();
        yield return new WaitForSeconds(5f);
        videoPlayer.Stop();
        screen.SetActive(false);
    }
}
