using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public List<Camera> cameras;
    public ChronoTrigger trigger;
    private int currentCamIndex = 0;

    void Start()
    {
        // init cams
        foreach (Camera cam in cameras)
            cam.enabled = false;
        cameras[currentCamIndex].enabled = true;

        // trigger callback
        if (trigger != null)
            trigger.Fire += SwitchCam;
    }

    private void SwitchCam()
    {
        cameras[currentCamIndex].enabled = false;

        if (currentCamIndex < cameras.Count - 1)
            currentCamIndex++;
        else
            currentCamIndex = 0;
        cameras[currentCamIndex].enabled = true;
    }
}
