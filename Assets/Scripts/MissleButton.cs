using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleButton : MonoBehaviour 
{
    public GameObject missle;
    bool isRunning;

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

        if(spawned
            && !isRunning)
        {
            StartCoroutine(WaitForButton());
            Instantiate(missle);
            spawned = false;
        }
    }

    IEnumerator WaitForButton()
    {
        isRunning = true;

        float time = 0;

        while (time < 5)
        {
            time += Time.deltaTime;

            yield return null;
        }

        isRunning = false;
    }
}