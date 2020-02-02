using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton2 : MonoBehaviour
{
    public GameObject StartOptions;
    public GameObject HintScreen2;

    void OnMouseDown()
    {
        StartOptions.SetActive(false);
        HintScreen2.SetActive(true);

    }
}
