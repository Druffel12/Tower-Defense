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
        // @cole: Don't use GameObject.Find every frame if it's gonna be the same
        //        object each time. Find it in start and cache it in a variable for
        //        future use.
        //
        //        Likewise for the GetComponent<Enemy>() call. Do it once and
        //        cache the result in a variable.
        CurrentScore += GameObject.Find("Deer").GetComponent<Enemy>().PScore;
    }
}
