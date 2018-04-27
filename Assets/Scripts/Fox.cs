using System.Collections;
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
        jump_available = true;
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
       // Debug.Log("Fox Collison with: " + collider.name);
        if (obj.GetComponent<Gravestone>() && jump_available)
        {
            animator.SetTrigger("JumpTrigger");
            jump_available = false;
        }
        else
        {
            animator.SetBool("Is Attacking", true);
            attacker.Attack(obj);
        }
    }
}
