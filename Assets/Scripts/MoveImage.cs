using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveImage : MonoBehaviour
{
    float speed = 50f;
    private Image bgImage;
    public Sprite[] img;
    private int indexCounter = -1;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        bgImage = GetComponent<Image>();
        bgImage.sprite = img[0];
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object to the right relative to the camera 1 unit/second.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void ChangeImage()
    {
        if (indexCounter == img.Length - 1) indexCounter = 0;
        else indexCounter++;
        bgImage.sprite = img[indexCounter];
        transform.position = startPosition;

    }
}
