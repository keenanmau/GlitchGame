using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour {

    [Range (0f, 1.5f)]public float walkSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * walkSpeed);
	}
}
