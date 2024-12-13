using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneEndingChange : MonoBehaviour
{
    public float delay = 9;
    public string NewLevel = "Start Menu";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}