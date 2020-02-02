using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{
    public GameObject screen;
    void OnMouseDown()
    {
        screen.SetActive(!screen.activeSelf);
    }
    
}
