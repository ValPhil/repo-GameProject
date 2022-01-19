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
    private float t = 3;
    public GameObject player;
    private int mana;

    void Start()
    {
        currentAmmo = bulletFire;
        
    }

    
    void Update()
    {
        mana = player.GetComponent<Status>().Mana;
        t += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (t>1 && mana >= 20)
            {
                shoot();
                t = 0;
            }
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
    private void shoot()
    {
        player.GetComponent<Status>().Mana -= 20;
        GameObject bullet = Instantiate(currentAmmo, transform.position, transform.rotation);     
    }
}
