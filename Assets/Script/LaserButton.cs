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

		Ray ray;
		RaycastHit hit;
		
		float t = 0;
		
		Quaternion myRotate = Quaternion.Euler(new Vector3(Random.Range(-50,10),Random.Range(-70,70),0));
		Quaternion invert = Quaternion.Inverse(myRotate);
		
		Vector3 newScale = Laser.transform.localScale;
		Laser.transform.rotation = myRotate;
		
		while (t < 2)
		{
			t += Time.deltaTime;
			
			// fire length
			newScale.z += 5f * Time.deltaTime;
			Laser.transform.localScale = newScale;
			
			//rotation
			// need to rotate to the center of the screen
			Laser.transform.rotation = Quaternion.RotateTowards(Laser.transform.rotation,invert,  40 * Time.deltaTime);
			
			yield return null;
		}

		newScale.z = 0;
		Laser.transform.localScale = newScale;
		_coRouIsRunning = false;
	}
}
