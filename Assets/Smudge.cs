using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smudge : MonoBehaviour
{
    public float HitPoints = 3f;
    Vector3 lastMousePosition;
    float startHP;
    void Start()
    {
        startHP = HitPoints;
    }
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
            GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 1f, HitPoints/(startHP-2.5f));
        }
        lastMousePosition = Input.mousePosition;
    }
}
