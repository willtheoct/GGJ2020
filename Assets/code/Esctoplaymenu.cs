using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject VicotryScreen;
    public GameObject TitleScreen;
    void OnMouseDown()
    {
        VicotryScreen.SetActive(false);
        TitleScreen.SetActive(true);
    }
}
