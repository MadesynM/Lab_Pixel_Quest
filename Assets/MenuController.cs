using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string startScene;
    public string nextScene;
    public string menuScene;

    public void LoadLevel()
    {
        SceneManager.LoadScene(startScene);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
   
}
