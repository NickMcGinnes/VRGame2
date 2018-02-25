using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDestructButton : MonoBehaviour
{
    private bool isRunning = false;
    public GameObject gameOverPanel;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Clicked()
    {
        if (!isRunning)
        {
            countdownText.gameObject.SetActive(enabled);
            StartCoroutine(SelfDestructSequence());
        }
    }

    IEnumerator SelfDestructSequence()
    {
        isRunning = true;

        float time = 10;
        float countdown = 0;

        while (time > countdown)
        {
            time -= Time.deltaTime;
            countdownText.text = "" + Mathf.RoundToInt(time); ;

            yield return null;
        }

        GameOver();
    }

    void GameOver()
    {
        gameOverPanel.gameObject.SetActive(enabled);
    }
}