using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleButton : MonoBehaviour 
{
    public GameObject missle;
    bool isRunning;
    public AudioClip[] buttonSounds;
    public AudioSource buttonAudioSource;
    public AudioSource rocketLaunchAudioSource;

    // Use this for initialization
    void Start () 
	{
        buttonAudioSource = gameObject.GetComponent<AudioSource>();
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

        rocketLaunchAudioSource.enabled = true;
        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
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

        rocketLaunchAudioSource.enabled = false;
        isRunning = false;
    }
}