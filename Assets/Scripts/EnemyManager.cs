using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // @cole: Prefer static objects to hold global state
    //        Or static functions are fine too
    public static float PlayerHealth = 100;
    public GameObject enemy;
    private float spawnTime;
    public int SpawnCount;
    public Transform[] SpawnPoint;
    public float Spawner;
    public int Wave;
    

	// Use this for initialization
	void Start ()
    {
        ResetTimer();
	}

    //void Spawn()
    //{
    //    if (PlayerHealth <= 0f)
    //    {
    //        return;
    //    }

    //    int SpawnPointIndex = 1;
    //    Instantiate(enemy, SpawnPoint[SpawnPointIndex].position, SpawnPoint[SpawnPointIndex].rotation);

    //}	
    //Begins wave spawn after defeating a wave and after a delay
    void Update()
    {
        spawnTime -= Time.deltaTime;

        //player days 
        if (PlayerHealth == 0)
        {
            Application.Quit();
        }

        // @cole: prefer early exit by checking your conditions ahead of time
        if( !(spawnTime <= 0.0f && SpawnCount > 0)) { return; }

        // (enemy, transform.position, Quaternion.identity);
        GameObject SpawnedDeer = ObjectPooler.SharedInstance.GetPooledObject();

        SpawnedDeer.SetActive(true);
        SpawnedDeer.transform.position = transform.position;

        //implement wave system

        if (SpawnCount > 0)
        {
            SpawnCount--;
        }
        ResetTimer();
    }

    void ResetTimer()
    {
        spawnTime = Spawner;
    }

}
