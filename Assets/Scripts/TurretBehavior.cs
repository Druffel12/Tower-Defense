﻿using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    bool Enemy = false;
    private Transform target;
    public float FireSpeed;
    public Transform Head;

	// Use this for initialization
	void Start ()
    {
		
	}
    // turret check for enemy tag and bool set
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Deer")
        {
            target = other.transform;
            Enemy = true;
        }
    }

    // Update is called once per frame
    //look at target
    void Update ()
    {
        if (target != null)
        {
            Head.LookAt(target);
            Debug.Log("shit doesnt work");
        }
	}
}
