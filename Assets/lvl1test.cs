using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl1test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(PlayerPrefsManager.getDifficulty());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
