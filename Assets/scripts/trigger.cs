using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

    public int camNumber;
    public Cam controller;

    void OnTriggerEnter(Collider other)
    {
        controller.DeactivateCameras();
        controller.activateCamera(camNumber);
    }
}
