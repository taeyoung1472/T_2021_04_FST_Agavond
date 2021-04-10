using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    private Gamemanager gameManager;
    public  void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "PlayBtn":
                SceneManager.LoadScene("Game");
                break;
        }       
    }
}
