using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleBehaviour : MonoBehaviour 
{
    float speed;
    public ParticleSystem particle;
    
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
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}