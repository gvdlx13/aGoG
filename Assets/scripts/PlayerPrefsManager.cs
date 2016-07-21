﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour
{

    // Use this for initialization

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFF_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetDifficulty(float volume)
    {
        if (volume > 0f && volume <= 3f)
        {
            PlayerPrefs.SetFloat(DIFF_KEY, volume);
        }
        else
        {
            Debug.LogError("Difficulty out of range");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFF_KEY);
    }

    public static void UnlockLevel (int level)
    {
        if (level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("Trying to unlock level not in build order");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool isLevelUnlocked = (levelValue == 1);
        if (level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            //return bool
            return isLevelUnlocked;
        }
        else
        {
            Debug.LogError("trying to query level not in build order");
            return false;
        }
        
    }

}