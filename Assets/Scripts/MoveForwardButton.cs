using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardButton : MonoBehaviour 
{
    public GameObject mech;
    public float speed;
    bool movingForward;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    void Clicked ()
    {
        if(mech.transform.position.z > 200)
        {
            speed *= -1;
        } else if (mech.transform.position.z < -92)
        {
            speed *= -1;
        }

        mech.transform.Translate(0, 0, -speed);
    }
}