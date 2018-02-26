using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, transform.forward, out hit, 100000.0f))
			{
				if (hit.collider != null)
				{
					//print("looking at " + hit.collider);
					hit.collider.gameObject.SendMessage("Clicked",SendMessageOptions.DontRequireReceiver);
				}
				
			}
		}
	}
}
