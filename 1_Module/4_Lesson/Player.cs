using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {
        coins++;

        print("Collected coins: " + coins);
    }
 
    //A method that lowers the player's health
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
