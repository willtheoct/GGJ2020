using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartButton : MonoBehaviour
{
    void OnMouseDown()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
