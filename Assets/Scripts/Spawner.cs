using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] attackerPrefabs;

	
	void Update () {
		foreach(GameObject thisAttacker in attackerPrefabs)
        {
            if (spawnTrigger(thisAttacker))
            {
                spawn(thisAttacker);
            }
        }
	}

    bool spawnTrigger(GameObject thisAttacker)
    {
        Attacker attacker = thisAttacker.GetComponent<Attacker>();
        float meanSpawnDelay = attacker.spawnTime;
        float spawnsPerSecond = 1 / spawnTime;

        return true;
    }

    void spawn(GameObject obj)
    {
        GameObject newAttacker = Instantiate(obj);
        newAttacker.transform.parent = transform;
        newAttacker.transform.position = transform.position;
    }
}
