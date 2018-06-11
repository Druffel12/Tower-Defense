using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTurret : MonoBehaviour
{
    public GameObject turretPrefab;
    private GameObject Turret;

    // @cole: could convert into property
    private bool TurretPlaceValid()
    {
        return Turret == null;
    }

    // ... like so!
    private bool isTurretPlacementValid
    {
        get
        {
            return Turret == null;
        }
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
