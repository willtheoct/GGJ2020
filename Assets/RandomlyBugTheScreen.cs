using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyBugTheScreen : MonoBehaviour
{
    public computer pc;
    float timer = 20f;
    void Start()
    {
        transform.parent = null;
        timer = 20f;
    }
    void Update()
    {
        if (!pc.bug.activeSelf)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0f)
        {
            pc.bug.SetActive(true);
            timer = 20f + Random.Range(0f, 20f);
        }
    }
}
