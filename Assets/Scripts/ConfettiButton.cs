using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiButton : MonoBehaviour 
{
    public ParticleSystem confettiParticleSystem;
    bool confettiOn = false;
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
        if (!isRunning
            && !confettiOn)
        {
            confettiParticleSystem.Play();
            confettiOn = true;
        } else if (confettiOn)
        {
            confettiParticleSystem.Stop();
            confettiOn = false;
        }

        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }
}