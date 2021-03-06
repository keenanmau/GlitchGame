﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public float autoLoadNextLevelAfter;

    public void Start()
    {
        if (autoLoadNextLevelAfter > 0)
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name, LoadSceneMode.Single);

    }

    public void QuitRequest()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void LoadPreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);
    }

}
