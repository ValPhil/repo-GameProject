using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;
    private NavMeshAgent agent;
    int x = 0;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        while(GameObject.FindGameObjectWithTag("PatrolWaypoints").transform.GetChild(x) != null)
        {
            waypoints[x] = GameObject.FindGameObjectWithTag("PatrolWaypoints").transform.GetChild(x);
            x++;
        }
        x = 0;
        transform.position = waypoints[0].position;
    }

    
    void Update()
    {
        if (agent.remainingDistance ==0f)
        {
            x++;
        }
        if (x> waypoints.Length-1)
        {
            x = 0;
        }
        if (!agent.pathPending && agent.remainingDistance == 0f)
        {
            agent.destination = waypoints[x].position;
        }
    }
}
