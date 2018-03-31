using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float  speed, damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
       
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Attacker attack_subject = collider.gameObject.GetComponent<Attacker>();
        Health health_subject = collider.gameObject.GetComponent<Health>();

        if(attack_subject && health_subject)
        {
            health_subject.takeDamage(damage);
            Destroy(gameObject);
        }
    }
}
