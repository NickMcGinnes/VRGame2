using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public float Sensitivity;
	
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		float rotLeftRight = Input.GetAxis("Mouse X") * Sensitivity;
		
		float rotUpDown = Input.GetAxis("Mouse Y") * Sensitivity;
		
		transform.Rotate(0,rotLeftRight,0);
		Camera.main.transform.Rotate(-rotUpDown,0,0);
	}
}