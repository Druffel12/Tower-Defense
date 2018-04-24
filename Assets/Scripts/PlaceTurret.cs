using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTurret : MonoBehaviour
{
    public GameObject turretPrefab;
    private GameObject Turret;

    private bool TurretPlaceValid()
    {
        return Turret == null;
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
