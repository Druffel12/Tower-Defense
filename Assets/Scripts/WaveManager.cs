using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int CurrentWave;
    public int EnemiesLeft;

	// Use this for initialization
	void Start ()
    {

        EnemiesLeft = GameObject.Find("SpawnPoint").GetComponent<EnemyManager>().SpawnCount;
        CurrentWave = GameObject.Find("SpawnPoint").GetComponent<EnemyManager>().Wave;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
