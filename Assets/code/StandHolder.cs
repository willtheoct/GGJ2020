using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandHolder : MonoBehaviour
{
    public GameObject glue;
    public GameObject Monitor;
    public Material GlueMat;

    Vector3 MonitorStartPos;
    Vector3 MonitorStartRotation;
    bool glued = false;
    void Start()
    {
        MonitorStartPos = Monitor.transform.position;
        MonitorStartRotation = Monitor.transform.eulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var colliders = Physics.OverlapSphere(transform.position, 0.05f, 0xffff);
        foreach (var c in colliders)
        {
            if (c.gameObject == glue || c.transform.IsChildOf(glue.transform))
            {
                glued = true;
                GetComponent<MeshRenderer>().material = GlueMat;
                return;
            }

            if (c.gameObject == Monitor || c.transform.IsChildOf(Monitor.transform))
            {
                Monitor.transform.position = MonitorStartPos;
                Monitor.transform.eulerAngles = MonitorStartRotation;
                Monitor.GetComponent<Rigidbody>().isKinematic = true;
            }
        }

    }
}
