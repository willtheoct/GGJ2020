using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{
    public GameObject PowerButtonHide;
    public GameObject BlackScreen;
    public GameObject WindowsScreen;
    public GameObject Smudge1;

    void OnMouseDown()
    {
        PowerButtonHide.SetActive(false);
        BlackScreen.SetActive(false);
        WindowsScreen.SetActive(true);
        Smudge1.SetActive(true);
    }
}
