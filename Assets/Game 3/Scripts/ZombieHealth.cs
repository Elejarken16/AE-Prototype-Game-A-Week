using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    public float enemyHealth = 50f;
    ZombieController enemyAI;
    public bool isEnemyDead;
   
    public ZombieController con;
    public NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        enemyAI = GetComponent<ZombieController>();
    }

    // Update is called once per frame
    public void DeductHealth(float deductHealth)
    {
        if (!isEnemyDead)
        {
            enemyHealth -= deductHealth;

            if (enemyHealth <= 0) { EnemyDead(); }
        }
    }

    //public void TakeDamage(float amount)
    //{
        //enemyHealth--;
        //if (enemyHealth <= 0f)
       // {
            
            //con.enabled = false;
            //nav.enabled = false;
            //this.enabled = false;
            
        //}
   // }

    void EnemyDead()
    {
        isEnemyDead = true;
        enemyAI.EnemyDeathAnim();
        Destroy(gameObject,5);
    }

}
