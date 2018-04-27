using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile, gun;

    private Animator animator;
    private GameObject projectileParent;
    private Spawner myLaneSpawner;

    private void Start()
    {
        animator = GetComponent<Animator>();
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }
        SetMyLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerAheadInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile);
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
        
    }

    bool IsAttackerAheadInLane() //todo
    {
        if(myLaneSpawner.transform.childCount <= 0) {

            return false;
        }
        foreach(Transform attacker in myLaneSpawner.transform) {
            if(attacker.transform.position.x > transform.position.x) {
                return true;
            }
        }
        return true;
    }

    void SetMyLaneSpawner()
    {
        Spawner[] spawnerList = GameObject.FindObjectsOfType<Spawner>();
        foreach(Spawner spawner in spawnerList) {
            if(spawner.transform.position.y == transform.position.y) {
                myLaneSpawner = spawner;
                return;
            }
        }
        Debug.Log("Can't Find spawner in lane");
    }


}
