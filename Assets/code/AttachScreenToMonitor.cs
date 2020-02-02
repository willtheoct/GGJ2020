using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//workaround for a unity bug - clicking on rigidbodies does not trigger mouse down, so we need to follow the rigidbody manually
public class AttachScreenToMonitor : MonoBehaviour
{
    public Transform monitorJoint;
    public Transform myJoint;

    // Update is called once per frame
    void FixedUpdate()
    {
        myJoint.position = monitorJoint.position;
        myJoint.rotation = monitorJoint.rotation;
    }
}
