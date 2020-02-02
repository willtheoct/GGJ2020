using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStartInSafeModeButton : MonoBehaviour
{
    public GameObject CodeDigit1;
    public GameObject CodeDigit2;
    public GameObject CodeDigit3;
    public GameObject CodeDigit4;
    public GameObject StartInSafeModeButton;
    void Update()
    {
        if (CodeDigit1.activeSelf
            && CodeDigit2.activeSelf
            && CodeDigit3.activeSelf
            && CodeDigit4.activeSelf)
        {
            StartInSafeModeButton.SetActive(true);
        }
    }
}
