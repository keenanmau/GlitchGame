using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

    [Tooltip("Average time between spawns")]
    public float spawnDelay;
    private float currentSpeed;
    private GameObject attackTarget;
    private Animator animator; 
    public float damage;

	void Start () {
        animator = gameObject.GetComponent<Animator>();
	}
	
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * currentSpeed);
        if (!attackTarget)
        {
            animator.SetBool("Is Attacking", false);
        }
	}

    public void setSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject obj)
    {
        attackTarget = obj;
        strikeCurrentTarget(damage);
    }

    public void strikeCurrentTarget(float damage_next)
    {
        if (attackTarget)
        {
            Health health = attackTarget.GetComponent<Health>();
            if(health) {
                health.takeDamage(damage_next);
                
            }
            
        }
        
    }
}
