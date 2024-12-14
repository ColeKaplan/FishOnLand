using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowFish : MonoBehaviour
{
    public GameObject fish;
    public float targetWidth = 960f;
    public float orthographicSize = .023f;
    public float yShift = -6f;
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
        float shift = fish.transform.position.y + halfHeight + yShift; // Maybe change 10 to 10 * screen.height / 800 or something
        Camera.main.transform.position = new Vector3(fish.transform.position.x, shift, -10);
    }
}
