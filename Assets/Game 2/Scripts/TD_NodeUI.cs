using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_NodeUI : MonoBehaviour
{
    public GameObject ui;

    private TD_Nodes target;


    public void SetTarget (TD_Nodes _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

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

}
