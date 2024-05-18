using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject finishUI;
 //   public GameObject playerUI;
    public GameObject Car;
    public Camera finishUICamera;
  //  public GameObject controls;


    public Text status;

    private void Start()
    {
        finishUICamera.enabled = false;
        StartCoroutine(waitforthefinish());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            StartCoroutine(finishzonetimer());

            status.text = "You Won";
            status.color = Color.black;

        }
        else if (other.gameObject.tag == "CarWaypointBased")
        {
            StartCoroutine(finishzonetimer());

            status.text = "You Lose";
            status.color = Color.red;
        }
    }

    IEnumerator waitforthefinish()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(25f);
        gameObject.GetComponent<BoxCollider>().enabled = true;

    }

    IEnumerator finishzonetimer()
    {
        finishUICamera.enabled = true;
      //  controls.SetActive(false);
        finishUI.SetActive(true);
      //  playerUI.SetActive(false);
        Car.SetActive(false);


        yield return new WaitForSeconds(5f);



    }
}
