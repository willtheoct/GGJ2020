using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraMonitor : MonoBehaviour
{
    public GameObject MainCamera;
    void Update()
    {
        MainCamera.transform.Translate(-Vector3.forward * Time.deltaTime);
    }
}
