using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Stopwatch : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public TextMeshProUGUI currentTimeText;
    public TextMeshProUGUI doneText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime += Time.deltaTime;
            
            if ((currentTime <= 0) || (ScoreManager.instance.points == 6))
            {
                stopwatchActive = false;
                doneText.text = "Well Done!";
                Debug.Log("Training session done.");
            }

        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\.fff");
    }

    public void startStopwatch()
    {
        stopwatchActive = true;
    }

    public void stopStopwatch()
    {
        stopwatchActive = false;
    }
}
