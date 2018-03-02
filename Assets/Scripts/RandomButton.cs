using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButton : MonoBehaviour 
{
    public AudioClip[] buttonSounds;
    public AudioSource buttonAudioSource;
    bool isRunning = false;

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
        if (!isRunning)
        {
            
        }

        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }
}