using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private int health = 10;

    public AudioSource audioSource;
    public AudioClip damageSound;

    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health > 0) {
            audioSource.PlayOneShot(damageSound);
        }
        else {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

}
