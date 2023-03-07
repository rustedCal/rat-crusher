using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timetext;
    private float time = 60f;

    void Update()
    {
        if(time >= 1)
        {
            time -= Time.deltaTime;
            timetext.text = time + "s";
        }
        else if(time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
