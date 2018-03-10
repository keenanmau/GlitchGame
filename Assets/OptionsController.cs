using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider, difficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;
    // Use this for initialization
    void Start() {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        Debug.Log(musicManager);
        volumeSlider.value = PlayerPrefsManager.getMasterVolume();
        difficultySlider.value = PlayerPrefsManager.getDifficulty();

    }
	
	// Update is called once per frame
	void Update () {
        musicManager.SetVolume(volumeSlider.value);

	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.setMasterVolume(volumeSlider.value);
        PlayerPrefsManager.setDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01a_Start");
    }
    public void setDefaults()
    {
        PlayerPrefsManager.setDifficulty(2f);
        PlayerPrefsManager.setMasterVolume(.8f);
        difficultySlider.value = PlayerPrefsManager.getDifficulty();
        volumeSlider.value = PlayerPrefsManager.getMasterVolume();
    }

}
