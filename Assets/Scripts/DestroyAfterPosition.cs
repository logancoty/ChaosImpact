using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterPosition : MonoBehaviour
{
    private int deletePos = -2;
    private void Update()
    {
        if (transform.position.z == deletePos)
            Destroy(this.gameObject);
    }
}
