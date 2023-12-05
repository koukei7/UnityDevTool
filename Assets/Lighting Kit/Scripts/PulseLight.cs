using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseLight : MonoBehaviour
{
    private new Light light;
    public float interval = 1f;
    float timer;
    
    void Start()
    {
        if (GetComponent<Light>() == null)
        {
            light = GetComponent<Light>();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            timer -= interval;
        }
    }
}
