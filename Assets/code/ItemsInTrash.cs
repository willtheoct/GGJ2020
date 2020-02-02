using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInTrash : MonoBehaviour
{
    public GameObject Bug;
    public GameObject MainCamera;
    public GameObject Screen;
    public GameObject Monitor;
    public GameObject[] thingsThatZoomOut;
    public float mindistance = 1F;
    public float ZoomSpeed = 0.02F;
    void OnTriggerEnter(Collider C)
    {
        if (C.GetComponentInChildren<CanPickUp>() != null)
        {
            C.transform.SetParent(transform);
        }
    }

    void Update()
    {
        Debug.Log("children: "+transform.childCount);
        Debug.Log("bug active: "+Bug.activeSelf);
        Debug.Log("screen active: "+Screen.activeSelf);
        Debug.Log("rb k:" + Monitor.GetComponent<Rigidbody>().isKinematic);
        if (transform.childCount > 3 && !Bug.activeSelf && Monitor.GetComponent<Rigidbody>().isKinematic && Screen.activeSelf)
        {
            Debug.Log("Victory!");
            if ((MainCamera.transform.position - Screen.transform.position).magnitude > mindistance)
            {
                MainCamera.transform.Translate(Vector3.forward * Time.deltaTime * ZoomSpeed);
            }
            foreach (var z in thingsThatZoomOut)
            {
                z.SetActive(false);
            }
        }
    }
}
