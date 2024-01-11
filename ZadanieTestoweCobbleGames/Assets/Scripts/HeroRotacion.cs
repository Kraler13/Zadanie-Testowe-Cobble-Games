using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroRotacion : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Hero hero;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        hero = GetComponent<Hero>();
    }
    void Update()
    {
        Vector3 lookDirection = navMeshAgent.velocity.normalized;
        if (lookDirection != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(lookDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * hero.maneuverability);
        }
    }
}
