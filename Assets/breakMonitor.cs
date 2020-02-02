using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakMonitor : MonoBehaviour
{
    public GameObject MonitorAndStand;
    void Start()
    {
        MonitorAndStand.GetComponent<Rigidbody>().isKinematic = false;
    }
}
