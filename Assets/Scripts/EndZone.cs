using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Deer")
        {
            Destroy(other.gameObject);
            EnemyManager.PlayerHealth -= 5;
        }
    }
}
