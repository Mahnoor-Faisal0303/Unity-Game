using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject carcontrol;
    public GameObject CountdownUI;
    void Start() {
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart() {
        yield return new WaitForSeconds(0.5f);
        CountdownUI.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1.0f);
        CountdownUI.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1.0f);
        CountdownUI.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1.0f);
        CountdownUI.GetComponent<Text>().text = "GO";
        CountdownUI.SetActive(false);
        carcontrol.SetActive(false);
    }
}
