using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkButton : MonoBehaviour
{
    public GameObject ErrorMsg;
    public GameObject DebuggingButton;
    void Update()
    {
    }
    void OnMouseDown()
    {
        ErrorMsg.SetActive(false);
        DebuggingButton.SetActive(false);
    }
}