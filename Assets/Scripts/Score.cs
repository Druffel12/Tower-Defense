using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    private int CurrentScore;
    // Use this for initialization
	void Start ()
    {
        CurrentScore = 0;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        CurrentScore += GameObject.Find("Deer").GetComponent<Enemy>().PScore;
    }
}
