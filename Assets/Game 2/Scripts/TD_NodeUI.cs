using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TD_NodeUI : MonoBehaviour
{
    public GameObject ui;

    public TMP_Text upgradeCost;
    public Button upgradeButton;

    public TMP_Text sellAmount;

    private TD_Nodes target;


    public void SetTarget (TD_Nodes _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "DONE";
            upgradeButton.interactable = false;
        }

        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    } 

    public void Upgrade()
    {
        target.UpgradeTurret();
        TD_BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        TD_BuildManager.instance.DeselectNode();
    }
}
