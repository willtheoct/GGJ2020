using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySwatter : MonoBehaviour
{
    bool isPickedUp = false;
    public float ArmLength = 1f;
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
            transform.LookAt(Vector3.down, Vector3.forward);
            GetComponent<Rigidbody>().isKinematic = false;
        }

        //if still being held, point it forward
        if (isPickedUp)
        {
            transform.LookAt(Vector3.forward, Vector3.up);
            transform.position = Camera.main.ScreenPointToRay(Input.mousePosition).direction*ArmLength+
                                 Camera.main.transform.position;
        }
    }
    void OnMouseDown()
    {
        isPickedUp = true;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
