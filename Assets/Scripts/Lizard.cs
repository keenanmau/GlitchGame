using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]

public class Lizard : MonoBehaviour
{
    private bool jump_available;
    private Animator animator;
    private Attacker attacker;

    void Start()
    {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        else
        {
            animator.SetBool("Is Attacking", true);
            attacker.Attack(obj);
        }
        //Debug.Log("Lizard Collison with: " + collider.name);
    }
}