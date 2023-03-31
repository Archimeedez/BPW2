using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCam : MonoBehaviour
{
    [SerializeField] CinemachineFreeLook MainCam;
    [SerializeField] CinemachineVirtualCamera ZoomCam;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ZoomCam.Priority = 1;
            MainCam.Priority = 0;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ZoomCam.Priority = 0;
            MainCam.Priority = 1;
        }
    }
}
