using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    TurretBehavior Enemy;
    public GameObject Bullet;
    public float FireDelay;
    public float Timer;

    // Use this for initialization
    void Start ()
    {
        Enemy = GetComponentInParent<TurretBehavior>();
    }
	
	// Update is called once per frame
    //creating bullet after a delay
	void Update ()
    {
        if (Enemy != null)
        {
            if(Enemy.Enemy)
            {
                if(Timer <= 0)
                {
                    Instantiate(Bullet, transform.position, transform.rotation);
                    Timer = FireDelay;
                }
                
                Timer -= Time.deltaTime;
            }
           
        }
	}
}
