using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleButton : MonoBehaviour 
{
    public GameObject missle;

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
        bool spawned = true;

        if(spawned)
        {
            Instantiate(missle);
            spawned = false;
        }
    }
}