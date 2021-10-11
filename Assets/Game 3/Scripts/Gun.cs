using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform camera;
    public GameObject hitFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayInput();
    }

    void PlayInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        RaycastHit hit;
        Physics.Raycast(camera.position, camera.forward,out hit);
        if (hit.collider.GetComponent<ZombieHealth>())
        {
            hit.collider.GetComponent<ZombieHealth>().TakeDamage();
            GameObject FX = Instantiate(hitFX, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(FX,1);

        }
    }

}