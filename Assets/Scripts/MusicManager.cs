using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicArray;
    private AudioSource audioSource;

    private void OnEnable()
    {
        Debug.Log("OnEnable called");
        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnSceneLoaded;
        
        
    }

    private void OnDisable()
    {
        
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetVolume(float newVolume)
    {
        audioSource.volume = newVolume;
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load " + name);
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        int level = scene.buildIndex;
        if(level == 0)
        {
            audioSource.loop = false;
        }
        else
        {
            audioSource.loop = true;
        }
        
        if (level >= 0)
        {
            AudioClip thisLevelMusic = levelMusicArray[level];
            Debug.Log("Playing Clip: " + thisLevelMusic);
            if (thisLevelMusic)
            {
                audioSource.clip = thisLevelMusic;
                audioSource.Play();
            }
        }
        else
        {
            Debug.LogError("Scene Index not in Build Order");
        }
    }
}
