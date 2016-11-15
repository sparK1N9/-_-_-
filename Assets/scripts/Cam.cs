using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {
    public GameObject[] Cameras;
    int currentCam;

    // Use this for initialization
    void Start () {
        DeactivateCameras();
        Cameras[0].SetActive(true);
        currentCam = 0;
    }

    public void activateCamera(int _camNumber)
    {
        Cameras[_camNumber - 1].SetActive(true);
        currentCam = _camNumber - 1;
    }

    public void DeactivateCameras()
    {
        for (int i = 0; i < Cameras.Length; i++)
        {
            Cameras[i].SetActive(false);
        }

    }
}
