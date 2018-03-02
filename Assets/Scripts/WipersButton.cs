using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WipersButton : MonoBehaviour
{
    [HideInInspector]
    public Animator wiperAnimator;
    [HideInInspector]
    public AudioSource myAudio;
    bool isRunning;

	// Use this for initialization
	void Start ()
    {
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
    }
}