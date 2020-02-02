using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySwatter : MonoBehaviour
{
    bool isPickedUp = false;
    public float ArmLength = 1f;
    public Transform ShouldBeAbleToReach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if dropped, point it downward
        if (!Input.GetMouseButton(0) && isPickedUp)
        {
            isPickedUp = false;
            GetComponent<Rigidbody>().useGravity = true;
            the.playersHandIsFull = false;
        }

        //if still being held, point it forward
        if (isPickedUp)
        {
            transform.LookAt(Vector3.forward, Vector3.up);
            ArmLength = (ShouldBeAbleToReach.position - Camera.main.transform.position).magnitude;
            
            var targetPosition = Camera.main.ScreenPointToRay(Input.mousePosition).direction*ArmLength+
                                 Camera.main.transform.position;
            GetComponent<Rigidbody>().MovePosition(targetPosition);
        }
    }
    void OnMouseDown()
    {
        if (!the.playersHandIsFull)
        {
            the.playersHandIsFull = true;
            isPickedUp = true;
            GetComponent<Rigidbody>().useGravity = false;
        }
        
    }
}

public static class the
{
    public static bool playersHandIsFull=false;
}
