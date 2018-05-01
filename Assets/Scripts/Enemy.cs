using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float DeerHealth = 30;
    public int PScore;
    PooledObject EnemyPool;


    void start()
    {
        EnemyPool = GetComponent<PooledObject>();
    }

    // Update is called once per frame
    //add score and return enemy too bool
    void Update ()
    {
		if(DeerHealth <= 0f)
        {
            EnemyPool.ReturnToPool();
            PScore += 5;
        }
	}
}
