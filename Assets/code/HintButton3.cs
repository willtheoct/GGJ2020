using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton3 : MonoBehaviour
{
    public GameObject StartOptions;
    public GameObject HintScreen3;

    void OnMouseDown()
    {
        StartOptions.SetActive(false);
        HintScreen3.SetActive(true);

    }
}
