using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes = 0;
    public int seconds = 0;
    public TextMeshProUGUI timerText;
    private float timer;

    void Start()
    {
        UpdateTimerText();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;
            seconds--;

            if (seconds < 0)
            {
                seconds = 59;
                minutes--;
            }

            if (minutes < 0)
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
            else
            {
                UpdateTimerText();
            }
        }
    }

    void UpdateTimerText()
    {
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
