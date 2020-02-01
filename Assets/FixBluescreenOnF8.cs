using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBluescreenOnF8 : MonoBehaviour
{
    public GameObject BlueScreen;
<<<<<<< HEAD
=======
    public GameObject StartupSettings;
>>>>>>> 00237862bab80c60486eddd353bce01a7d63de2f
    void Update()
    {
        if (Input.GetButtonDown("f8"))
        {
            BlueScreen.SetActive(false);
<<<<<<< HEAD
=======
            StartupSettings.SetActive(true);
>>>>>>> 00237862bab80c60486eddd353bce01a7d63de2f
        }
    }
}
