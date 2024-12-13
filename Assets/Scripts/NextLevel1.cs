using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{
    public string strTag;
    public string strSceneName;
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)

    {
        if (col.collider.tag == strTag)
            transform.position = new Vector3(-8, 1, 0);
            SceneManager.LoadScene(strSceneName);
    }
}
