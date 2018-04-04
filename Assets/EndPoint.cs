using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;


public class EndPoint : MonoBehaviour
{

    NavMeshAgent agent;
    public GameObject end;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = end.transform.position;
    }


    void Update()
    {

    }
}
