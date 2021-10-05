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

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return TD_PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn (TD_Nodes node)
    {
        if(TD_PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Broke");
            return;
        }

        TD_PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret build! Money left: " + TD_PlayerStats.Money);
    }

    public void SelectNode(TD_Nodes node)
    {
        selectedNode = node;
        turretToBuild = null;
    }

    public void SelectTurretToBuild(TD_TurretBlueprint turret)
    {
        turretToBuild = turret;
        selectedNode = null;
    }
}
