using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouLossTrigger : MonoBehaviour
{
    public GameObject youLossPanel;
 
    public string Cube = "cube3";
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "cube3")
        {
            youLossPanel.SetActive(true);
            
        }

    }
}
