using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton1 : MonoBehaviour
{
    public GameObject StartOptions;
    public GameObject HintScreen1;

    void OnMouseDown()
    {
        StartOptions.SetActive(false);
        HintScreen1.SetActive(true);

    }
}

