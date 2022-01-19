using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public GameObject portal;
    public int Health = 10;
    

    void Start()
    {
        portal.SetActive(false);
        
    }
    private void OnCollisionEnter(Collision other)
    {
        Bullet bullet = other.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            Health -= bullet.damage;
        }
        if (Health < 1)
        {
            Die();
        }
    }
     private void Die()
    {
        portal.SetActive(true);
        Destroy(gameObject);
    }

}
