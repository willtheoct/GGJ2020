using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBluescreenOnF8 : MonoBehaviour
{
    public GameObject BlueScreen;
    void Update()
    {
        if (Input.GetButtonDown("f8"))
        {
            BlueScreen.SetActive(false);
        }
    }
}
