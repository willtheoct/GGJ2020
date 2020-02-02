using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject TitleScreen;
    public GameObject BlueScreen;
    public GameObject blankTheScreen;
    
    void OnMouseDown ()
    {
        TitleScreen.SetActive(false);
        BlueScreen.SetActive(true);
        blankTheScreen.SetActive(true);
    }
}
