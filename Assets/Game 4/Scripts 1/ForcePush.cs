using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePush : MonoBehaviour
{
    public float chargeRate;
    
    public float pushAmount;
    private float amountStart;

    public float pushRadius;
    private float radiusStart;

    // Start is called before the first frame update
    void Start()
    {
        amountStart = pushAmount;
        radiusStart = pushRadius;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            pushAmount += chargeRate;
            pushRadius += chargeRate;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            DoPush();
        }
    }

    void DoPush()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, pushRadius);

        foreach(Collider pushObjec in colliders)
        {
            if (pushObjec.CompareTag("Box"))
            {
                Rigidbody pushedBody = pushObjec.GetComponent<Rigidbody>();

                pushedBody.AddExplosionForce(pushAmount, Vector3.up, pushRadius);
            }
        }

        pushAmount = amountStart;
        pushRadius = radiusStart;
    }

}
