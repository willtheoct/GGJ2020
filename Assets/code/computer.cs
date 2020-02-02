using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer : MonoBehaviour
{
    public GameObject bug;
    void OnCollisionEnter(Collision c) {
        //if fly swatter hits, de-bug
        if (c.rigidbody.GetComponent<FlySwatter>() != null && c.relativeVelocity.magnitude>0.38f)
        {
            bug.SetActive(false);
        }
    }
}
