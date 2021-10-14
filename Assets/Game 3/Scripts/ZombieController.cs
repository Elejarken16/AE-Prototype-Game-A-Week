using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    Transform target;
    Animator controller;
    Animator anim;
    bool isDead = false;
    public bool canAttck = true;
    [SerializeField]
    float chaseDistance = 2f;
    public float damageAmount = 5f;
    [SerializeField]
    float attackTime = 2f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        controller = GetComponentInParent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        controller.SetFloat("speed", Mathf.Abs(agent.velocity.x + agent.velocity.z));

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance < chaseDistance && canAttck && !PlayerHealth.singleton.isDead)
        {
            AttackPlayer();
        }
        else if (distance > chaseDistance && !isDead)
        {
            ChasePlayer();
        }
        
        
        else if (PlayerHealth.singleton.isDead)
        {
            DisableEnemy();
        }
    }

    public void EnemyDeathAnim()
    {
        isDead = true;
        anim.SetTrigger("isDead");
    }

    void ChasePlayer()
    {
        agent.updatePosition = true;
        agent.SetDestination(target.position);
        anim.SetBool("isWalking", true);
        anim.SetBool("isAttacking", false);
    }

    void AttackPlayer()
    {
        agent.updatePosition = false;
        anim.SetBool("isWalking", false);
        anim.SetBool("isAttacking", true);
        StartCoroutine(AttackTime());
    }

    void DisableEnemy()
    {
        canAttck = false;
        anim.SetBool("isWalking", false);
        anim.SetBool("isAttacking", false);
    }

    IEnumerator AttackTime()
    {
        canAttck = false;
        yield return new WaitForSeconds(0.5f);
        PlayerHealth.singleton.PlayerDamage(damageAmount);
        yield return new WaitForSeconds(attackTime);
        canAttck = true;
    }

}
