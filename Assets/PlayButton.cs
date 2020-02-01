using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject TitleScreen;
    public GameObject playButton;
    public GameObject BlueScreen;
    void Update()
    {   
    }
    void OnMouseDown ()
    {
        playButton.SetActive(false);
        TitleScreen.SetActive(false);
        BlueScreen.SetActive(true);
    }
}
