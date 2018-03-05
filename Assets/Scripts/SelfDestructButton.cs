using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDestructButton : MonoBehaviour
{
    private bool isRunning = false;
    public float countdownAmount;
    public GameManager gameManagerScript;
    public Text countdownText;
    public AudioClip[] buttonSounds;
    public AudioSource buttonAudioSource;
    public AudioSource selfDestructAudioSource;

    // Use this for initialization
    void Start()
    {
        buttonAudioSource = gameObject.GetComponent<AudioSource>();
        gameManagerScript = gameManagerScript.gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Clicked()
    {
        if (!isRunning)
        {
            //countdownText.gameObject.SetActive(true);
            StartCoroutine(SelfDestructSequence());
        }

        selfDestructAudioSource.enabled = true;
        buttonAudioSource.clip = buttonSounds[Random.Range(0, buttonSounds.Length)];
        buttonAudioSource.Play();
    }

    IEnumerator SelfDestructSequence()
    {
        isRunning = true;

        float time = countdownAmount;
        float countdown = 0;

        while (time > countdown)
        {
            time -= Time.deltaTime;
            //countdownText.text = "" + Mathf.RoundToInt(time);

            yield return null;
        }

        gameManagerScript.gameOver = true;
    }
}