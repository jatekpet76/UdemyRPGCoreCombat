﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverController : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    private NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
       navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navAgent.SetDestination(_target.transform.position);
    }
}
