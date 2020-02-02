using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBluescreenOnF8 : MonoBehaviour
{
    public GameObject BlueScreen;
    public GameObject StartupSettings;
    void Update()
    {
        if (Input.GetButtonDown("f8"))
        {
            BlueScreen.SetActive(false);
            StartupSettings.SetActive(true);
        }
    }
}
