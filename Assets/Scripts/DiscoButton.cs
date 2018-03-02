using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoButton : MonoBehaviour 
{
    bool isRunning;
    public Animator myAnimator;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    void Clicked()
    {
        if (!isRunning)
        {
            myAnimator.enabled = true;
        }
    }
}