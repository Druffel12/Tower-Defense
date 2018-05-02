using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour {

    public float Distance = 1.0f;
    ObjectPooler Pooled;

    public bool Spawnable;


    //sets bool to false
    private void Awake()
    {
        Spawnable = false;
    }
	
    //gets object pool
    void start()
    {
        Spawnable = GetComponent<ObjectPooler>();
    }
    
    //setting mouseposition
    void Mouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    //spawning turret function
    void SpawnObject()
    {
        GameObject SpawnedObject = Pooled.GetPooledObject();
        SpawnedObject.transform.position = transform.position;

        SpawnedObject.SetActive(true);
    }

    // gets mouses input
    void Update ()
    {
        Mouse();
        if(Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }
	}
}

// Now here's a sexy lady 
//
// 
//    WWWWWWWW
//  MMMMMMMMMMMM
//  W|  _  _  |W
//  W|  0  0  |W
//  (          )
//  W\_  __  _/W
//  WWW\    /WWW
// ____/    \____
///              \
//| |\   /\   /| |
//| |  '    '  | |
//| |          | |
//| |__________| |
//\_|   \{}/   |_/
//  |    \/    |
//  |     |    |
//  |     |    |
//  | ___ | __ |
//  |/___\|/__\|
//
//
//  Her name is "LadyName.tostring"   