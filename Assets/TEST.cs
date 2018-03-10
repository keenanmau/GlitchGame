using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(PlayerPrefsManager.getDifficulty());
        PlayerPrefsManager.setDifficulty(1f);
        Debug.Log(PlayerPrefsManager.getDifficulty());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
