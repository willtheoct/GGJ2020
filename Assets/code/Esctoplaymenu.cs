using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esctoplaymenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
