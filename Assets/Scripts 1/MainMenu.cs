using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Challenge1");
    }

    public void credits()
    {
        SceneManager.LoadSceneAsync("old credits");
    }

    public void howToPlay() 
    {
        SceneManager.LoadSceneAsync("old howToPlay");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("old start menu");
    }
    public void next()
    {
        //SceneManager.LoadSceneAsync("howToPlay");
    }
}
