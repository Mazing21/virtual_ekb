using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveImage : MonoBehaviour
{
    float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object to the right relative to the camera 1 unit/second.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
