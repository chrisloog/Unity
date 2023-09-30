using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinsCollector : MonoBehaviour
{
    public AudioClip coinsSound;

    private int coins;

    public AudioSource audioSource;

    public void CollectCoins()
    {
        coins += 1;
        audioSource.PlayOneShot(coinsSound);

        print("Coins: " + coins);
    }
}
