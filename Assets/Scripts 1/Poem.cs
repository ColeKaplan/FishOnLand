using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Poem : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadSceneAsync("Start Menu");
    }
    public void next()
    {
        SceneManager.LoadSceneAsync("howToPlay");
    }
}
