using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FollowTarget : MonoBehaviour
{

    [SerializeField] private Transform targetToFollow;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(targetToFollow.position);   
    }

}
