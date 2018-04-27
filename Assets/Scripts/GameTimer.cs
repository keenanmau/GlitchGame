using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    private Slider timerSlider;
    public float timeLimit = 30;
    private GameObject winLabel;


    private bool endLevelTrigger = false;
    private AudioSource audioSource;
    private LevelManager levelManager;
    
	void Start () {
        timerSlider = GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
        levelManager = FindObjectOfType<LevelManager>();
        FindWinLable();
        winLabel.SetActive(false);
    }

    private void FindWinLable() {
        winLabel = GameObject.Find("WinLabel");
        if (!winLabel) {
            Debug.Log("No Winlabel");
        }
    }

    void Update() {
        timerSlider.value = 1 - (Time.timeSinceLevelLoad / timeLimit);
        if (Time.timeSinceLevelLoad >= timeLimit && !endLevelTrigger) {
            audioSource.Play();
            winLabel.SetActive(true);
            Invoke("LoadNextLevel", audioSource.clip.length);
            endLevelTrigger = true;
        }
    }

    void LoadNextLevel() {
        levelManager.LoadNextLevel();
    }
        
    
}
