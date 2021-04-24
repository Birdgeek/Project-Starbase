using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuScene : MonoBehaviour
{
    public Scene newGameScene;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void newGame()
    {

        SceneManager.LoadScene(newGameScene.ToString());
    }
    public void quitGame()
    {
        Debug.Log("You have quit the game");
        Application.Quit(1);
    }
}
