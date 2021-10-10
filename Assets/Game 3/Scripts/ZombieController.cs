using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent nav;
    Transform player;
    Animator controller;
    // Use this for initialization
    void Awake()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        controller = GetComponentInParent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
        controller.SetFloat("speed", Mathf.Abs(nav.velocity.x + nav.velocity.z));
    }
}
