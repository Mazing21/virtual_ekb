using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float _score = 0;
    public TMP_Text _text;
    //    void Start()
    //    {
    //        CountDecrease();
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {

    //    }

    //    void CountDecrease()
    //    {
    //        _score++;
    //        Invoke("CountDecrease", 1f);
    //
    //}


    //2

    //void Start()
    //{
    //    StartCoroutine(TimerCoroutine());
    //}

    //IEnumerator TimerCoroutine()
    //{
    //    while (true)
    //    {
    //        _score++;
    //        yield return new WaitForSeconds(1f);
    //    }
    //}

    float timeBetween = 2f;
    float needTime = 0;
    //3

    void Update()
    {
        if(needTime < Time.time)
        {
            needTime = Time.time + timeBetween;
            _score++;
            StaticController.totalScore = _score;

            _text.text = "" + StaticController.totalScore;
        }
            
        
    }
    void Start()
    {
        _score = StaticController.totalScore;
    }
}
