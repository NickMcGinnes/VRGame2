using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myReticule : MonoBehaviour
{
	public GameObject Cube;

	private Vector3 origin;
	// Use this for initialization
	void Start ()
	{
		origin = Cube.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		if (Physics.Raycast(transform.position, transform.forward, out hit, 20.0f))
		{
			if (hit.collider != null)
			{
				Cube.transform.position = hit.point;
			}
		}
		else
		{
			Cube.transform.localPosition = origin;
		}
	}
}
