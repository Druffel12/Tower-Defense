using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float Velocity;
    public Rigidbody RB;
    public float Damage;
    public float Lifetime = 5;
    PooledObject BulletPool;

	// Use this for initialization
	void Start ()
    {
        BulletPool = GetComponent<PooledObject>(); 
        RB = GetComponent<Rigidbody>();
        BulletPool.ReturnWithDelay(Lifetime);
	}
    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Deer"))
        {
            GameObject Enemy = GameObject.Find("Deer");
            Enemy enemy = Enemy.GetComponent<Enemy>();
            Enemy.GetComponent<Enemy>().DeerHealth -= Damage;
            BulletPool.ReturnToPool();
            
        }
    }
    // Update is called once per frame
    void Update ()
    {
        RB.AddForce(transform.up * Velocity);
	}
}
