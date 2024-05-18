using System.Collections;
using System.Collections.Generic;
using TMPro; // Make sure to include the TMP namespace
using UnityEngine;
using UnityEngine.UI;

public class countDown1 : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI uiText; // Use TextMeshProUGUI for TMP

    public int Duration;
    public float GoDisplayDuration = 2f;
    private int remainingDuration;

    void Start() {
        Begin(Duration); 
    }

    private void Begin(int seconds) // Use camelCase for method parameter names
    {
        remainingDuration = seconds;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer() {
        while (remainingDuration >= 0) {
            
            int seconds = remainingDuration % 60;

            // Use TMP's rich text tags for formatting
            uiText.text = $"{seconds:D1}";

            
            remainingDuration--;


            yield return new WaitForSeconds(1f);
        }

        OnEnd();
    }

    private IEnumerator DisplayGoAndHide() {
        uiText.text = "Go";
        yield return new WaitForSeconds(GoDisplayDuration);
        uiText.text = ""; // Hide the text
    }
    private void OnEnd() {
        StartCoroutine(DisplayGoAndHide());
        print("End");
    }
}

