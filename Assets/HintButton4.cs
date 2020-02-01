using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton4 : MonoBehaviour
{
    public GameObject StartOptions;
    public GameObject HintScreen4;

    void OnMouseDown()
    {
        StartOptions.SetActive(false);
        HintScreen4.SetActive(true);

    }
}