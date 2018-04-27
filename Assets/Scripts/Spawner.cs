using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float level_difficulty = 1;
    public GameObject[] attackerPrefabs;

	
	void Update () {
		foreach(GameObject thisAttacker in attackerPrefabs)
        {
            if (IsTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
	}


    void Spawn(GameObject attackerObject)
    {
        GameObject newAttacker = Instantiate(attackerObject);
        newAttacker.transform.parent = transform;
        newAttacker.transform.position = transform.position;
    }

    bool IsTimeToSpawn(GameObject attackerGameObject)
    {
        Attacker attacker = attackerGameObject.GetComponent<Attacker>();

        float difficulty_setting_modifier = level_difficulty * (1 + (PlayerPrefsManager.getDifficulty() / 4));
        //difficulty values between 1 and 3 made the spawn delay between between difficulties too drastic. 
        float meanSpawnDelay = attacker.spawnDelay;
        float spawnsPerSecond = difficulty_setting_modifier  / meanSpawnDelay;

        if(Time.deltaTime > meanSpawnDelay)
        {
            Debug.LogWarning("Spawn rate capped by frame rate");
        }

        float threshold = spawnsPerSecond * Time.deltaTime / 5;

        if(Random.value < threshold)
        {
            return true;
        } else {
            return false;
        }
    }
}
