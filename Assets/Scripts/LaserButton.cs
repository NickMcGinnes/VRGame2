using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserButton : MonoBehaviour
{

	public GameObject laser;
	private bool _coRouIsRunning = false;
	
	// Use this for initialization
	void Start ()
    {
        laser.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Clicked()
	{
        laser.SetActive(true);
        if (!_coRouIsRunning)
        {
            StartCoroutine(LaserControl());
        }
	}

	IEnumerator LaserControl()
	{
		_coRouIsRunning = true;

		//Ray ray;
		//RaycastHit hit;
		
		float t = 0;
		
		Quaternion myRotate = Quaternion.Euler(new Vector3(Random.Range(-50,10),Random.Range(-70,70),0));
		Quaternion invert = Quaternion.Inverse(myRotate);
		
		Vector3 newScale = laser.transform.localScale;
        laser.transform.rotation = myRotate;
		
		while (t < 2)
		{
			t += Time.deltaTime;
			
			// fire length
			newScale.z += 5f * Time.deltaTime;
            laser.transform.localScale = newScale;

            //rotation
            // need to rotate to the center of the screen
            laser.transform.rotation = Quaternion.RotateTowards(laser.transform.rotation,invert,  40 * Time.deltaTime);
            
			yield return null;
		}

		newScale.z = 0;
        laser.transform.localScale = newScale;
        laser.SetActive(false);
        _coRouIsRunning = false;
	}
}
