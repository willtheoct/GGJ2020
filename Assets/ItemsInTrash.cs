using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInTrash : MonoBehaviour
{
    void OnTriggerEnter(Collider C)
    {
        if (C.GetComponent<Bottle>() != null)
        {
            C.transform.parent = transform;
        }
    }
}
