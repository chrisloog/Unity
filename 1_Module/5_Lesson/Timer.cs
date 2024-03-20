using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes = 0;
    public int seconds = 0;

    void Update()
    {
        seconds += Mathf.RoundToInt(Time.deltaTime);

        if (seconds >= 60)
        {
            seconds -= 60;
            minutes--;

            if (minutes < 0)
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}