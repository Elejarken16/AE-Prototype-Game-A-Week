using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
            return;

        if(TD_PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Game Over!");
    }

}
