using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraMonitor : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Screen;
    public float maxdistance = 1F;
    void Update()
    {
        if ((MainCamera.transform.position - Screen.transform.position).magnitude < maxdistance)
        {
            MainCamera.transform.Translate(-Vector3.forward * Time.deltaTime);
        }
    }
}
