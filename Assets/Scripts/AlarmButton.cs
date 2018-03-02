using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmButton : MonoBehaviour 
{
    public AudioClip[] buttonSounds;
    public AudioSource buttonAudioSource;
    bool isRunning = false;
    public GameObject alarm;

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
            alarm.SetActive(true);
        }

        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }
}