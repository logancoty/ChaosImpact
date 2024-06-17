using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    float timer = 0f;
    float tilt_angle = 15;

    public void Update()
    {
        timer += (Time.deltaTime / 3f);

        float angle = Mathf.Sin(Time.time + timer) * (tilt_angle);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
