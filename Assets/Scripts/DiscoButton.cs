using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoButton : MonoBehaviour 
{
    public AudioSource buttonAudioSource;
    public AudioSource discoAudioSource;
    bool isRunning = false;
    public AudioClip[] buttonSounds;
    public Animator myAnimator;
    //public Animation discoAnimation;

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

        discoAudioSource.enabled = true;
        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }
}