using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapSelect1 : MonoBehaviour
{
    public GameObject button;
    public GameObject Map;
    public void Use()
    {
        button.SetActive(false);
        Map.SetActive(true);
    }
    public void Exit()
    {
        button.SetActive(true);
        Map.SetActive(false);
    }
}
