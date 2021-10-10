using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public int round = 1;
    int zombiesInRound = 10;
    int zombiesSpawnedInRound = 0;
    float zombiesSpawnTimer = 0;
    public Transform[] zombiesSpawnPoints;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (zombiesSpawnedInRound < zombiesInRound)
        {
            if (zombiesSpawnTimer > 30)

            {
                SpawnZombies();
                zombiesSpawnTimer = 0;
            }
            else
            {
                zombiesSpawnTimer++;
            }
        }
    }

    void SpawnZombies()
    {

    }
}


