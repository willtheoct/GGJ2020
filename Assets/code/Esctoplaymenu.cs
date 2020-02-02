using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("f12"))
        {
            Application.LoadLevel("SampleScene");
        }
    }
}
