using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float starting_health;

    public void takeDamage(float damage)
    {
        starting_health -= damage;
        if(starting_health <= 0)
        {
            //insert death animation here. 
           DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);

    }
}
