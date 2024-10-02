using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI scoreText;
    public GameObject defeatUI;

    void Update()
    {
        UpdateScore();
        CheckDefeat();
    }

    void UpdateScore()
    {
        if (player != null)
        {
            scoreText.text = player.points.ToString();
        }
    }

    void CheckDefeat()
    {
        if (player == null)
        {
            defeatUI.SetActive(true);
        }
    }

    public void OnClickRestart()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
