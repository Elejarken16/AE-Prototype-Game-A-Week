using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TD_MoneyUI : MonoBehaviour
{
    public TMP_Text moneyText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + TD_PlayerStats.Money.ToString();
    }
}
