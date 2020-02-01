using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject TitleScreen;
    public GameObject StartupSettings;
    void Update()
    {
    }
    void OnMouseDown()
    {
        TitleScreen.SetActive(true);
        StartupSettings.SetActive(false);
    }
}