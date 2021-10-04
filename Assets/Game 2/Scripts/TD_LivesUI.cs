using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TD_LivesUI : MonoBehaviour
{
    public TMP_Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = TD_PlayerStats.Lives.ToString() + " LIVES";
    }
}
