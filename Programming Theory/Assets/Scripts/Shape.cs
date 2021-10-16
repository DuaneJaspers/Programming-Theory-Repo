using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class Shape : MonoBehaviour
{
    public float Speed = 3;

    protected NavMeshAgent m_Agent;

    protected void Awake()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        m_Agent.speed = Speed;
        m_Agent.acceleration = 999;
        m_Agent.angularSpeed = 999;
    }

    protected abstract void SayName();

    // Abstration
    internal void GoTo(Vector3 position)
    {
        SayName();
        m_Agent.SetDestination(position);
        m_Agent.isStopped = false;
    }
}