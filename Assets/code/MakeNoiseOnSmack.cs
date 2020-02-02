using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MakeNoiseOnSmack : MonoBehaviour
{
    Rigidbody rb;
    static int bottleNoises;
    public float noiseTimeLeft = 0f;
    bool ReadyForNoise = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //when noise is done
        if (noiseTimeLeft < 0 && !ReadyForNoise)
        {
            bottleNoises--;
            ReadyForNoise = true;
        }
        //if one is playing, count down
        if (!ReadyForNoise)
        {
            noiseTimeLeft -= Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.relativeVelocity.magnitude > 2f && ReadyForNoise && bottleNoises<6 && Time.timeSinceLevelLoad>3f)
        {
            noiseTimeLeft = 2f;
            bottleNoises++;
            ReadyForNoise = false;
            GetComponent<AudioSource>().Play();
        }
    }
}
