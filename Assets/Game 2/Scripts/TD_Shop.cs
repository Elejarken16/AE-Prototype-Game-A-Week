using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_Shop : MonoBehaviour
{
    public TD_TurretBlueprint standardTurret;
    public TD_TurretBlueprint missileLauncher;

    TD_BuildManager buildManager;

    void Start()
    {
        buildManager = TD_BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissileLancher()
    {
        Debug.Log("Another");
        buildManager.SelectTurretToBuild(missileLauncher);
    }

}
