using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapClick : MonoBehaviour
{
    public void ForestPlay()
    {
        SceneManager.LoadScene("1Forest");
    }
    public void TownPlay()
    {
        SceneManager.LoadScene("2Town");
    }
    public void PlayGroundPlay()
    {
        SceneManager.LoadScene("3PlayGround");
    }
    public void FarmPlay()
    {
        SceneManager.LoadScene("4Farm");
    }
    public void NewClearPlay()
    {
        SceneManager.LoadScene("5Newclear");
    }
    public void BossPlay()
    {
        SceneManager.LoadScene("6Boss");
    }
}
