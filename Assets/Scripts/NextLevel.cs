using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string strTag;
    public string strSceneName;
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)

    {
        if (col.collider.tag == strTag)
        { 
            SceneManager.LoadScene(strSceneName);
        }
    }
}
