using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public CoinsCounter coinsCounter;
    public Health health;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    void Update()
    {
        // Updating the player's health value
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.health;
		
        // Updating the text with the number of coins
        coinsCounterText.text = coinsCounter.coins.ToString();
    }
}