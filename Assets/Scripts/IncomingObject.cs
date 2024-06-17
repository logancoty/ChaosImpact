using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomingObject : MonoBehaviour
{
    public float speed = 1f;

    void FixedUpdate()
    {
        speed += (Time.deltaTime / 2f);
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
