using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravityFalling : MonoBehaviour
{
    public string strTag;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)

    {
        if (col.collider.tag == strTag)
        {
            rb.gravityScale = 1.0f;
        }
    }
}
