using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Transform camera;
    public GameObject hitFX;
    public ParticleSystem muzzleFlash;

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
        muzzleFlash.Play();

        RaycastHit hit;
        Physics.Raycast(camera.transform.position, camera.transform.forward,out hit, range);
        if (hit.collider.GetComponent<ZombieHealth>())
        {
            hit.collider.GetComponent<ZombieHealth>().TakeDamage(damage);
            GameObject FX = Instantiate(hitFX, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(FX,1);

        }
    }

}
