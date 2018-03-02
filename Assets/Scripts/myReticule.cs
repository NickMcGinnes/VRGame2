using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myReticule : MonoBehaviour
{
	public GameObject Cube;

	private Vector3 _origin;

	private Vector3 _orignalScale;

	private float _defaultDistance = 1;
	// Use this for initialization
	void Start ()
	{
		_origin = Cube.transform.localPosition;
		_orignalScale = Cube.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		if (Physics.Raycast(transform.position, transform.forward, out hit, 20.0f))
		{
			if (hit.collider != null)
			{
				Cube.transform.position = hit.point;
				Cube.transform.localScale = _orignalScale * (hit.distance);
			}
		}
		else
		{
			Cube.transform.localPosition = _origin;
			Cube.transform.localScale = _orignalScale * _defaultDistance;
		}
	}
}
