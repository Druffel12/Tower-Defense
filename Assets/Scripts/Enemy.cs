using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float DeerHealth = 30;
    public int PScore;
	
	// Update is called once per frame
	void Update ()
    {
		if(DeerHealth <= 0f)
        {
            Destroy(gameObject);
            PScore += 5;
        }
	}
}
