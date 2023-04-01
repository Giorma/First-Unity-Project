using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void play() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void howToPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void quit() 
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }

}
