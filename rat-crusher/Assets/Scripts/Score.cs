using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    public GameObject GameOver;
    private float time = 5f;


    void Update()
    {
        if(time >= 0)
        {
            time -= Time.deltaTime;
            timeText.text = Mathf.Round(time) + "s";
        }
        else if(time < 0)
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
        }
    }
}
