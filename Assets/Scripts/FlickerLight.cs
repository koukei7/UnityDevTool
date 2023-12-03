using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    private new Light light;
    public float minIntensity = 0f;
    public float maxIntensity = 1f;
    [Range(1, 100)]
    public int smoothing = 25;

    Queue<float> smoothQueue;
    float lastSum = 0;

    public void Reset()
    {
        smoothQueue.Clear();
        lastSum = 0;
    }

    void Start()
    {
        smoothQueue = new Queue<float>(smoothing);
        if (GetComponent<Light>() == null)
        {
            light = GetComponent<Light>();
        }
    }

    void Update()
    {
        if (GetComponent<Light>() == null)
            return;

        while (smoothQueue.Count >= smoothing)
        {
            lastSum -= smoothQueue.Dequeue();
        }

        float newVal = Random.Range(minIntensity, maxIntensity);
        smoothQueue.Enqueue(newVal);
        lastSum += newVal;

        GetComponent<Light>().intensity = lastSum / (float)smoothQueue.Count;
    }

}