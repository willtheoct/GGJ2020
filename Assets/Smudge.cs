using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smudge : MonoBehaviour
{
    public float HitPoints=3f;
    Vector3 lastMousePosition;
    private void OnMouseOver()
    {
        //if the mouse has moved and the mouse button is down
        if (Input.mousePosition != lastMousePosition && Input.GetMouseButton(0) &&! the.playersHandIsFull)
        {
            HitPoints -= Time.deltaTime;
            if (HitPoints <= 0f)
            {
                Destroy(gameObject);
            }
        }
        lastMousePosition = Input.mousePosition;
    }
}
