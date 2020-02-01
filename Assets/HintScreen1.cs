using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScreen1 : MonoBehaviour
{
    public GameObject HintScreen1screen;
    public GameObject StartOptions;
    public GameObject HintButton1;
    public GameObject CodeDigit1;
    void Update()
    {
        if (Input.GetKeyDown("7"))
        {
            HintScreen1screen.SetActive(false);
            StartOptions.SetActive(true);
            HintButton1.SetActive(false);
            CodeDigit1.SetActive(true);
        }
    }
}
