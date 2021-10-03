using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TD_Nodes : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    TD_BuildManager buildManager;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = TD_BuildManager.instance;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
            return;

        if(turret != null)
        {
            Debug.Log("Can't Build");
            return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
            return;

        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
