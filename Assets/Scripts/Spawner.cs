﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] attackerPrefabArray;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacker in attackerPrefabArray)
        {
            if (isTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
	}

    bool isTimeToSpawn (GameObject attackerGameObject)
    {
        Attacker attacker = attackerGameObject.GetComponent<Attacker>();
        float meanSpawnDelay = attacker.seenEverySeconds;
        float spawnsPerSecond = 1 / meanSpawnDelay;
        if (Time.deltaTime > meanSpawnDelay)
        {
            Debug.LogWarning("Spawn capped by frame rate");
        }

        float threshold = spawnsPerSecond * Time.deltaTime;
        //print("Threshold: " + threshold);
        //print("Random Value: " + Random.value);
        if (Random.value < threshold)
        {
            return true;
        } else
        {
            return false;
        }
    }

    void Spawn (GameObject myGameObject)
    {
        GameObject myAttacker = Instantiate (myGameObject) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }
}
