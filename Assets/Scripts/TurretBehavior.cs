using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    public bool Enemy = false;
    private Transform target = null;
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
           
        }
	}
}
