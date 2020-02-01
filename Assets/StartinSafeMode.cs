using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartinSafeMode : MonoBehaviour
{
    public GameObject WindowsScreen;
    public GameObject StartUpSettings;
    public GameObject ZoomOutToMontior;
    public GameObject PowerButton;
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        StartUpSettings.SetActive(false);
        WindowsScreen.SetActive(true);
        ZoomOutToMontior.SetActive(true);
        PowerButton.SetActive(true);
    }
}
