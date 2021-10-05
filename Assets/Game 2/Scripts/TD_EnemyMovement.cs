using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TD_Enemy))]
public class TD_EnemyMovement : MonoBehaviour
{
    private Transform target;
    private int wavepointIndex = 0;

    private TD_Enemy enemy;

    void Start()
    {
        enemy = GetComponent<TD_Enemy>();

        target = TD_Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }

        enemy.speed = enemy.startSpeed;
    }


    void GetNextWaypoint()
    {
        if (wavepointIndex >= TD_Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = TD_Waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        TD_PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
