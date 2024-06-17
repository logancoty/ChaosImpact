using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTimePeriod : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeToLive = 5f;
    private void Start()
    {
        if(transform.parent != null)
            Destroy(this.transform.parent.gameObject, TimeToLive);
        else
            Destroy(this.transform.gameObject, TimeToLive);

    }
}
