using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{	
	// OnTriggerEnter is called when another collider touches this collider.
	private void OnTriggerEnter()
	{
		if (this.gameObject.tag == "Heart" || this.gameObject.tag == "DoublePoints")
			Destroy(this.transform.gameObject);
		else
			Destroy(this.transform.parent.gameObject);
	}
}
