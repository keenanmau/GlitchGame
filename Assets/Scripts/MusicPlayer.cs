using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public AudioClip loadSound;
	// Use this for initialization
	void Start () {
        AudioSource.PlayClipAtPoint(loadSound, transform.position);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
