using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_Shop : MonoBehaviour
{
    TD_BuildManager buildManager;

    void Start()
    {
        buildManager = TD_BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseMissileLancher()
    {
        Debug.Log("Another");
        buildManager.SetTurretToBuild(buildManager.missileLancherPrefab);
    }

}
