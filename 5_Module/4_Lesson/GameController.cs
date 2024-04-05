using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static void SaveLevel()
    {
        PlayerPrefs.SetInt("level", LevelController.level);
    }

    public void ClearSave()
    {
        ClearLevel();
        ClearCrystals();
        ClearHealthGrade();
    }

    public static void ClearLevel()
    {
        PlayerPrefs.SetInt("level", 1);
    }

    public static void SaveCrystals()
    {
        PlayerPrefs.SetInt("crystals", Corn.crystals);
    }
 
    public static void ClearCrystals()
    {
        PlayerPrefs.SetInt("crystals", 0);
    }

    public static void SaveHealthGrade()
    {
        PlayerPrefs.SetInt("healthGrade", Corn.singleton.health);
    }

    public static void ClearHealthGrade()
    {
        PlayerPrefs.SetInt("healthGrade", 0);
    }



}