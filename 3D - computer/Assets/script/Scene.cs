using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public Gamemanager gameManager;
    public DontDestroyOnLoad2 main_canvas;
    public  void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "PlayBtn":
                SceneManager.LoadScene("Game");
                main_canvas.Change();
                break;
            case "TestBtn":
                SceneManager.LoadScene("Base");
                main_canvas.Change();
                break;
        }
    }
}
