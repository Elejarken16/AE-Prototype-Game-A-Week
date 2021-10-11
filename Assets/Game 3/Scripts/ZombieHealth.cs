using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    public int health = 3;
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

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            anim.Play("Die");
            //con.enabled = false;
            nav.enabled = false;
            this.enabled = false;
        }
    }

}
