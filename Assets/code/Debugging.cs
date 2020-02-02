using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
    public GameObject Errormsg;
    void Update()
    {
    }
    void OnMouseDown()
    {
       Errormsg.SetActive(true);
    }
}
