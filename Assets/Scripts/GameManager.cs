using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
    public bool gameOver;
    public GameObject gameOverPanel;
    public Image blackFill;
    float alpha;

	// Use this for initialization
	void Start ()
	{
        blackFill.gameObject.SetActive(true);
        alpha = blackFill.color.a;
    }
	
	// Update is called once per frame
	void Update () 
	{
        // Fade from black
        alpha -= Time.deltaTime / 2;
        Color newColor = new Color(0, 0, 0, alpha);
        blackFill.color = newColor;

        if(alpha <= 0)
        {
            blackFill.gameObject.SetActive(false);
        }

        if (gameOver)
        {
            GameOver();
        }
	}

    public void RestartButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void GameOver()
    {
        gameOverPanel.gameObject.SetActive(enabled);
    }
}