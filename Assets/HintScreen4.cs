using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScreen4 : MonoBehaviour
{
    public GameObject HintScreen4screen;
    public GameObject StartOptions;
    public GameObject HintButton4;
    public GameObject CodeDigit4;
    public GameObject ErrorMsg;
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            HintScreen4screen.SetActive(false);
            StartOptions.SetActive(true);
            HintButton4.SetActive(false);
            CodeDigit4.SetActive(true);
            ErrorMsg.SetActive(false);
        }
    }
}