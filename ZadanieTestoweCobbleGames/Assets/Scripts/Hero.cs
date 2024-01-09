using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour
{
    public float speed;
    public float maneuverability;
    public float endurance;
    [SerializeField] private InputMenager inputMenager; 
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = speed;
        navMeshAgent.angularSpeed = maneuverability;
    }

    void Update()
    {
        Vector3 lookDirection = navMeshAgent.velocity.normalized;
        if (lookDirection != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(lookDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * maneuverability);
        }
    }

    public void MoveToDestination(Vector3 destination)
    {
        Debug.Log(destination);
        navMeshAgent.SetDestination(destination);

       
    }
}
