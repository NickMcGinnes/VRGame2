using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WipersButton : MonoBehaviour
{
    [HideInInspector]
    public Animator wiperAnimator;
    [HideInInspector]
    public AudioSource myAudio;
    public AudioSource buttonAudioSource;
    bool isRunning = false;
    public AudioClip[] buttonSounds;

    // Use this for initialization
    void Start ()
    {
        buttonAudioSource = gameObject.GetComponent<AudioSource>();
        wiperAnimator = gameObject.GetComponentInChildren<Animator>();
        myAudio = gameObject.GetComponentInChildren<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void Clicked()
    {
        if (!isRunning)
        {
            wiperAnimator.enabled = true;
            myAudio.enabled = true;
        }

        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }
}