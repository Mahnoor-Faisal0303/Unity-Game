using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = false; // Initialize as false
    public TMP_Text timeText;

    private float countdownTimer = 3f; // Countdown timer for the delay

    // Start is called before the first frame update
    void Start()
    {
        // You can start the countdown timer here, or it will start automatically in the first frame
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeIsRunning)
        {
            // Countdown before starting the time
            if (countdownTimer > 0)
            {
                countdownTimer -= Time.deltaTime;
            }
            else
            {
                timeIsRunning = true; // Start the time counting after the countdown
            }
        }

        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
