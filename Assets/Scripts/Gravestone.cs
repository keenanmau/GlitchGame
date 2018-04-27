﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour {

    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();

    }

     void OnTriggerStay2D(Collider2D collider) {
        Attacker attacker = collider.gameObject.GetComponent<Attacker>();
        if (attacker) {
            animator.SetTrigger("underAttack");
        }
    }


}
