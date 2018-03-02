using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleBehaviour : MonoBehaviour 
{
    float speed;
    
	// Use this for initialization
	void Start () 
	{
        speed = Random.Range(2, 6);
	}
	
	// Update is called once per frame
	void Update () 
	{
        transform.Translate(0, 0, speed);
        Destroy(this.gameObject, 10);
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Building")
        {
            Destroy(this.gameObject);
        }
    }
}