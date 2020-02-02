using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutToDesk : MonoBehaviour
{
    public GameObject Screen;
    public GameObject Smudge1;
    public GameObject MoveOut;
    public GameObject BreakMonitor;
    void Update()
    {
        if (Screen.activeSelf && Smudge1 == null)
        {
            MoveOut.SetActive(true);
            BreakMonitor.SetActive(true);
        }
    }
}