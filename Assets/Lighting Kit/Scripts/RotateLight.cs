using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight: MonoBehaviour
{
    public Vector3 RotateAmount; 
    [Range(1, 25)]
    public int RotationMultiplier = 1;

    void Update()
    {
        transform.Rotate((RotateAmount * Time.deltaTime)* RotationMultiplier);
    }
}
