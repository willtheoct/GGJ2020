using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScreen3 : MonoBehaviour
{
    public GameObject HintScreen3screen;
    public GameObject StartOptions;
    public GameObject HintButton3;
    public GameObject CodeDigit3;
    public GameObject ErrorMsg;
    void Update()
    {
        if (Input.GetKeyDown("4"))
        {
            HintScreen3screen.SetActive(false);
            StartOptions.SetActive(true);
            HintButton3.SetActive(false);
            CodeDigit3.SetActive(true);
            ErrorMsg.SetActive(false);
        }
    }
}