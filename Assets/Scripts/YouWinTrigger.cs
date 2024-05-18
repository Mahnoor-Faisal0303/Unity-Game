using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinTrigger : MonoBehaviour
{
    public GameObject youWinPanel;
    public AudioSource audio;
    public string Cube = "cube3";
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "cube3")
        {
            youWinPanel.SetActive(true);
            audio.Play();
        }
    }
}
