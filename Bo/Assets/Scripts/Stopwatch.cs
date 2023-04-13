using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;

public class Stopwatch : MonoBehaviour
{
    bool StopwatchActive = false;
    float currentTime;
    public TMP_Text currentTimeText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (StopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");

        if(Input.GetKeyDown(KeyCode.W)) 
        {
            StopwatchActive = true;
        }
        


    }

    public void StopStopWatch()
    {
        StopwatchActive = false;
    }
}