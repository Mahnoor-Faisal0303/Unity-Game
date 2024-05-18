using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;

    // Call this method from the button's OnClick event
    public void SwitchCameraMode()
    {
        if (CamMode == 3)
        {
            CamMode = 0;
        }
        else
        {
            CamMode += 1;
        }
        StartCoroutine(ModeChange());
    }

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            SwitchCameraMode();
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}
