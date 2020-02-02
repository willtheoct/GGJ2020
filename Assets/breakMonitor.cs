using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakMonitor : MonoBehaviour
{
    public GameObject MonitorAndStand;
    void Start()
    {
        var rb = MonitorAndStand.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.AddForce(Vector3.up);

    }
}
