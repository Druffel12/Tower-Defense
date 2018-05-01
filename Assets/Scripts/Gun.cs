using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform barrel1;
    public Transform barrel2;
    TurretBehavior Enemy;
    public GameObject Bullet;



    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Enemy == true)
        {

            Instantiate(Bullet, transform.position, Bullet.transform.rotation);
        }
	}
}
