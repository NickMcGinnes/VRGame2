using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoButton : MonoBehaviour 
{
    public AudioSource buttonAudioSource;
    bool isRunning = false;
    public AudioClip[] buttonSounds;
    public Animator myAnimator;

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
            myAnimator.enabled = true;
        }

        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }
}