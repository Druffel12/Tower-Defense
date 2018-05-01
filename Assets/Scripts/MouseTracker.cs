using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour {

    public GameObject particle;
	
    //shows mouse
    void start()
    {
        Cursor.visible = true;
    }

    void OntriggerEnter(Collider other)
    {
        //if()
        //{

        //}
    }

    // gets mouses input
    void Update ()
    {
	    if(Input.GetButtonDown("Fire1"))
        {
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           if (Physics.Raycast(ray))
                Instantiate(particle, transform.position, transform.rotation);
       
        }	
	}
}
