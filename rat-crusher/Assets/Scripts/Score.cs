using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject player;
    public GameObject gameOver;
    private float time = 5f;
    private int score;
    private int highScore;

    void Update()
    {
        Timer();
        Scored();
    }

    private void Timer()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            timeText.text = Mathf.Round(time) + "s";
        }
        else if (time < 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            finalScoreText.text = "Score: " + score;
            highScoreText.text = "Highscore: " + highScore;
        }
    }

    private void Scored()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }
        //score = player.GetComponent<PlayerMove>().score;
        if(score >= highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
