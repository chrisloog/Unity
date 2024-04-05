using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int health;

    public static int crystals = 0;
    public int initHealth;
    public int healthPerUpgrade;



    private void Awake()
    {
        singleton = this;
        crystals = PlayerPrefs.GetInt("crystals");
        int healthBonus = healthPerUpgrade * PlayerPrefs.GetInt("healthGrade", 0);
        health = initHealth + healthBonus;
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health -= 1;
        }
    }

    public static void AddCrystals(int newCrystals)
    {
        crystals += newCrystals;

        GameController.SaveCrystals();
    }

    public void DecCrystals(int priceInCrystals)
    {
        crystals -= priceInCrystals;
        GameController.SaveCrystals();
    }


}