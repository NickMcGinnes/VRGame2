using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserButton : MonoBehaviour
{

	public GameObject Laser;
	private bool _coRouIsRunning = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Clicked()
	{
		if (!_coRouIsRunning)
		StartCoroutine(LaserControl());
	}

	IEnumerator LaserControl()
	{
		_coRouIsRunning = true;
		float t = 0;
		Vector3 newScale = Laser.transform.localScale;
		Quaternion myRotate = Quaternion.Euler(new Vector3(Random.Range(-45,45),Random.Range(-45,45),0));
		Laser.transform.rotation = myRotate;
		while (t < 2)
		{
			t += Time.deltaTime;
			
			// fire length
			newScale.z += 5f * Time.deltaTime;
			Laser.transform.localScale = newScale;
			
			//rotation
			// need to rotate to the center of the screen
			Laser.transform.rotation = Quaternion.RotateTowards(Laser.transform.rotation,Quaternion.identity,  20 * Time.deltaTime);
			
			yield return null;
		}

		newScale.z = 0;
		Laser.transform.localScale = newScale;
		_coRouIsRunning = false;
	}
}
