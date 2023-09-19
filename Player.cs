using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private int health = 10;

    public AudioSource audioSource;
    public AudioClip damageSound;

    public AudioClip coinsSound;

    private int coins;

    public void TakeDamage(int damage)
    {

        health -= damage;
        print("Player's health: " + health);

        if (health > 0) {
            audioSource.PlayOneShot(damageSound);
        }
        else {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    public void CollectCoins()
    {
        coins += 1;
        audioSource.PlayOneShot(coinsSound);

        print("Coins: " + coins);
    }

}
