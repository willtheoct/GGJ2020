using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScreen2 : MonoBehaviour
{
    public GameObject HintScreen2screen;
    public GameObject StartOptions;
    public GameObject StartButton2;
    public GameObject CodeDigit2;
    void Update()
    {
        if (Input.GetKeyDown("5"))
        {
            HintScreen2screen.SetActive(false);
            StartOptions.SetActive(true);
            StartButton2.SetActive(false);
            CodeDigit2.SetActive(true);
        }
    }
}