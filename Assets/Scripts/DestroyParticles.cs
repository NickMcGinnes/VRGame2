﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticles : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        Destroy(this, 5);
	}
}