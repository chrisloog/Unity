using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private int health = 10;

    public AudioSource audioSource;
    public AudioClip damageSound;

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
}
