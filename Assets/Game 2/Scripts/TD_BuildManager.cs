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

    public GameObject standardTurretPrefab;
    public GameObject missileLancherPrefab;
    

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
