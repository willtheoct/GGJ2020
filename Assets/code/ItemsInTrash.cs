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
    public GameObject victoryScreen;

    List<Rigidbody> trash=new List<Rigidbody>();
    void OnTriggerEnter(Collider C)
    {
        if (C.GetComponentInChildren<CanPickUp>() != null)
        {
            trash.Add(C.attachedRigidbody);
        }
    }

    void Update()
    {
        if (trash.Count > 3 && !Bug.activeSelf && Monitor.GetComponent<Rigidbody>().isKinematic && Screen.activeSelf)
        {
            victoryScreen.SetActive(true);
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
