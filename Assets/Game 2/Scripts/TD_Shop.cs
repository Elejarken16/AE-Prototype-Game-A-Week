using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_Shop : MonoBehaviour
{
    public TD_TurretBlueprint standardTurret;
    public TD_TurretBlueprint missileLauncher;
    public TD_TurretBlueprint laserBeamer;

    TD_BuildManager buildManager;

    void Start()
    {
        buildManager = TD_BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissileLancher()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
