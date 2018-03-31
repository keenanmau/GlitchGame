﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Attacker))]

public class Fox : MonoBehaviour {

    
    private bool jump_available;
    private Animator animator;
    private Attacker attacker;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        Debug.Log("Fox Collison with: " + collider.name);
        if (obj.GetComponent<Gravestone>())
        {
            animator.SetTrigger("JumpTrigger");
        }
        else
        {
            animator.SetBool("Is Attacking", true);
            attacker.Attack(obj);
        }
    }
}
