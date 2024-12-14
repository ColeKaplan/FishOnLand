using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float targetWidth = 960f;
    public float orthographicSize = .023f;
    public float targetBottomY = -4.8f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float aspectRatio = (float)Screen.width / Screen.height;
        Camera.main.orthographicSize = orthographicSize * targetWidth / (2f * aspectRatio);


        float halfHeight = Camera.main.orthographicSize;
        // Position the camera so its bottom aligns with the targetBottomY
        float widthShift = targetBottomY + halfHeight; 



        Camera.main.transform.position = new Vector3(0,widthShift,-20);
    }
}
