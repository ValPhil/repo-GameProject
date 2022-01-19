using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bullet;
    public GameObject FirePoint;
    bool inRange = false;
    float t = 3f;
    public float ShootingSpeed;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.LookAt(other.transform);
            
        }
             
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.rotation = Quaternion.identity;
            inRange = false;
        }
        
    }

    void Update()
    {
        if (inRange == true)
        {
            t = t + Time.deltaTime;
            if (t>2f)
            {
                Shoot();
                t = 0f;
            }
        }
        
    }
    private void Shoot()
    {
        Instantiate(bullet,FirePoint.transform.position,FirePoint.transform.rotation);        
    }
}
