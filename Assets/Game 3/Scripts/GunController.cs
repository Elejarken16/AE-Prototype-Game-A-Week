using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [Header("Gun Settings")]
    public float fireRate = 0.1f;
    public int clipSize = 30;
    public int reserveAmmoCapacity = 270;

    bool _canShoot;
    int _currentAmmoInClip;
    int _ammoInReserve;

    // Start is called before the first frame update
    void Start()
    {
        _currentAmmoInClip = clipSize;
        _ammoInReserve = reserveAmmoCapacity;
        _canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && _canShoot && _currentAmmoInClip > 0)
        {
            _canShoot = false;
            _currentAmmoInClip--;
            StartCoroutine(ShootGun());
        }
        else if(Input.GetKeyDown(KeyCode.R) && _currentAmmoInClip < clipSize && _ammoInReserve > 0)
        {
            int amountNeeded = clipSize - _currentAmmoInClip;
            if(amountNeeded >= _ammoInReserve)
            {
                _currentAmmoInClip += _ammoInReserve;
                _ammoInReserve -= amountNeeded;
            }
            else
            {
                _currentAmmoInClip = clipSize;
                _ammoInReserve -= amountNeeded;
            }
        }
    }

    IEnumerator ShootGun()
    {
        yield return new WaitForSeconds(fireRate);
        _canShoot = true;
    }

}
