using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_BuildManager : MonoBehaviour
{
    public static TD_BuildManager instance;

    

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!!");
        }
        instance = this;
    }

    

    public GameObject buildEffect;

    private TD_TurretBlueprint turretToBuild;
    private TD_Nodes selectedNode;

    public TD_NodeUI nodeUI;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return TD_PlayerStats.Money >= turretToBuild.cost; } }

   

    public void SelectNode(TD_Nodes node)
    {

        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }

        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild(TD_TurretBlueprint turret)
    {
        turretToBuild = turret;

        DeselectNode();
        
    }

    public TD_TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }

}
