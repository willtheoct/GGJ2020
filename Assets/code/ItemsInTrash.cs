using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInTrash : MonoBehaviour
{
    public GameObject Bug;
    public GameObject MainCamera;
    public GameObject Screen;
    public GameObject Monitor;
    public float mindistance = 1F;
    public float ZoomSpeed = 0.02F;
    void OnTriggerEnter(Collider C)
    {
        if (C.GetComponent<MakeNoiseOnSmack>() != null)
        {
            C.transform.parent = transform;
            if (transform.childCount > 3 && Bug.activeSelf && Monitor.GetComponent<Rigidbody>().isKinematic)
            {
                if ((MainCamera.transform.position - Screen.transform.position).magnitude > mindistance)
                {
                    MainCamera.transform.Translate(Vector3.forward * Time.deltaTime * ZoomSpeed);
                }
            }
        }
    }
}
