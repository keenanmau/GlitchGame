using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Start_ : MonoBehaviour {

    private MusicManager musicmanager;
    // Use this for initialization
    void Start() {


        musicmanager = GameObject.FindObjectOfType<MusicManager>();
        if (musicmanager)
        {
            musicmanager.SetVolume(PlayerPrefsManager.getMasterVolume());
        }
        else
        {
            Debug.LogError("No music manager found.");
        }
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
