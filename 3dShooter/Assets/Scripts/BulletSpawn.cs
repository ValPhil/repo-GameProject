using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bulletFire;
    public GameObject bulletIce;
    public GameObject bulletAir;
    public GameObject bulletEarth;    
    private GameObject currentAmmo;

    void Start()
    {
        currentAmmo = bulletFire;        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(currentAmmo, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            currentAmmo = bulletFire;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            currentAmmo = bulletIce;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            currentAmmo = bulletAir;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            currentAmmo = bulletEarth;
        }
    }
}
