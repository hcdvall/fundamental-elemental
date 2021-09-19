using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panel;
    void Start() 
    {
        //SceneManager.UnloadScene("InGame");
        panel.SetActive(true);    
    }
    public void startGame()
    {
        SceneManager.LoadSceneAsync("InGame");
        panel.SetActive(false);
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
