using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankTheScreenForABit : MonoBehaviour
{
    public float timer = 0.4f;
    void Start()
    {
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Camera.main.cullingMask = 0xffff;
        }
    }
}
