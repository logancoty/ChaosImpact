using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundY : MonoBehaviour
{
    public float speed = 10;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, speed);
    }
}
