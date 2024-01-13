using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI pointsCounterText;
    public GameObject defeatUI;

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            defeatUI.SetActive(true);
        }
        pointsCounterText.text = player.points.ToString();
    }

    public void OnClickRestart()
    {
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

}
