using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowerScript : MonoBehaviour
{
    public List<GameObject> FollowPoints = new List<GameObject>();
    public List<GameObject> Followers = new List<GameObject>();
    public GameObject PointToFollowNow;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        navMeshAgent.SetDestination(PointToFollowNow.transform.position);
    }
}
