using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{

    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

}
