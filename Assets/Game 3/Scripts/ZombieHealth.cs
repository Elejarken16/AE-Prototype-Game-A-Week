using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    public float health = 50f;
    public Animator anim;
    public ZombieController con;
    public NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {
        health--;
        if (health <= 0f)
        {
            anim.Play("Die");
            con.enabled = false;
            nav.enabled = false;
            this.enabled = false;
            //WaitForSeconds 2 destroy gameobject
            //Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
