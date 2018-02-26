using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDestructButton : MonoBehaviour
{
    private bool isRunning = false;
    public GameManager gameManagerScript;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
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
            countdownText.gameObject.SetActive(true);
            StartCoroutine(SelfDestructSequence());
        }
    }

    IEnumerator SelfDestructSequence()
    {
        isRunning = true;

        float time = 2;
        float countdown = 0;

        while (time > countdown)
        {
            time -= Time.deltaTime;
            countdownText.text = "" + Mathf.RoundToInt(time);

            yield return null;
        }

        gameManagerScript.gameOver = true;
    }
}