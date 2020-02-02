using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{
    public GameObject screen;
    void OnMouseDown()
    {
        screen.SetActive(!screen.activeSelf);
        if (screen.activeSelf)
        {
            GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 0f, 1f);

        }
        else
        {
            GetComponent<MeshRenderer>().material.color = new Color(1f, 0f, 0f, 1f);
        }
    }
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = new Color(1f, 0f, 0f, 1f);
    }
}
