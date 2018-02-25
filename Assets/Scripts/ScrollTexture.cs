using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
	private float _offset = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		_offset -=  4 * Time.deltaTime;
		Vector2 vecOffset = new Vector2(0, _offset);
		gameObject.GetComponent<Renderer>().material.mainTextureOffset = vecOffset;
	}
}
