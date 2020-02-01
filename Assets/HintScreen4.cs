using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScreen4 : MonoBehaviour
{
    public GameObject HintScreen4screen;
    public GameObject StartOptions;
    public GameObject HintButton4;
    void Update()
    {
        if (Input.GetKeyDown("7"))
        {
            HintScreen4screen.SetActive(false);
            StartOptions.SetActive(true);
            HintButton4.SetActive(false);
        }
    }
}