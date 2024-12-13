using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolOnLedge : MonoBehaviour
{
    public float speed;
    public float distance = 2f;
    private bool movingLeft = true;

    public Transform groundChecker;


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D groundinfo = Physics2D.Raycast(groundChecker.position, Vector2.down, distance);

        if(groundinfo.collider == false)
        {
            if(movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }
        }

    }
}
