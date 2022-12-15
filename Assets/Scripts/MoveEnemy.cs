using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
   public Transform target;
    Vector3 destination;
    NavMeshAgent enemy;

    void Start()
    {
        // Cache enemy component and destination
        enemy = GetComponent<NavMeshAgent>();
        destination = enemy.destination;
    }

    void Update()
    {
        // Update destination if the target moves one unit
        if (Vector3.Distance(destination, target.position) > 1.0f)
        {
            destination = target.position;
            enemy.destination = destination;
        }
    }
}
