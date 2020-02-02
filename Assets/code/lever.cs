using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    Quaternion startRotation;
    bool isPullingDown = false;
    bool isTwisting = false;
    float Angle = 0f;
    void Start()
    {
        startRotation = transform.rotation;
    }
    void OnMouseDown()
    {
        if (Quaternion.Angle(transform.rotation, startRotation) <= 5f)
        {
            if (Random.value > 0.2f)
            {
                isPullingDown = true;
            }
            else
            {
                transform.rotation= Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 6f, 0));
                isTwisting = true;
            }
        }
    }
    void Update()
    {
        if (isPullingDown)
        {
            var targetRotation = Quaternion.Euler(new Vector3(90f, 0, 0) + startRotation.eulerAngles);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation ,Time.deltaTime*5);
            if(Quaternion.Angle(transform.rotation, targetRotation)<5f)
            isPullingDown = false;
        }
        else if (isTwisting)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, Time.deltaTime * 500, 0));
            if (Quaternion.Angle(transform.rotation, startRotation) < 5f)
                isTwisting = false;
        }
        else
        transform.rotation = Quaternion.Slerp(transform.rotation, startRotation, Time.deltaTime * 5);
    }
}
