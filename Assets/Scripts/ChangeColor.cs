using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image img;
    private Color col;
    float maxAlpha = 1f;
    float minAlpha = 0.1f;
    public float alphaDelta = 0.001f;
    public bool darker = false;
    public float sumTime = 0;
    public MoveImage mi;
    public float ind;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SetAlpha());
        col = img.color;
        col.a = 0;
        img.color = col;
        ind = maxAlpha;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCol();

    }


    void ChangeAlpha(float alpha)
    {
        col.a = alpha;
        img.color = col;
    }

    void ChangeCol()
    {
        if (ind >= maxAlpha)
        {
            darker = false;
            mi.ChangeImage();

        }
        if (ind <= minAlpha)
        {
            darker = true;
        }
        if (darker)
        {
            ind += alphaDelta;
        }
        else
        {
            ind -= alphaDelta;
        }
        ChangeAlpha(ind);
    }
}

    
