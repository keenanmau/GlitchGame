using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }else
        {
            Debug.LogError("Master Volume out of range");
        }
    }

    public static float getMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static float getDifficulty ()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    public static bool isLevelUnlocked(int level)
    {
        if (level <= SceneManager.sceneCountInBuildSettings - 1 && level >= 0)
        {
            return (PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) > 0);
        }else{
            Debug.LogError("Level Unlock out of bounds");
            return false;
        }
    }

    public static void UnlockLevel(int level)
    {
        if(level <= SceneManager.sceneCountInBuildSettings - 1 && level >= 0)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("Level Unlock query out of bounds");
        }
    }

    public static void setDifficulty(float difficulty)
    {
        if(difficulty >= 1 && difficulty <= 3)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty Out of Bounds");

        }
    }

    public static void setMasterVolume(float mastervolume)
    {
        if (mastervolume > 0 && mastervolume < 10)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, mastervolume);
        }
        else
        {
            Debug.LogError("Volume set Out of Bounds");

        }
    }


}
