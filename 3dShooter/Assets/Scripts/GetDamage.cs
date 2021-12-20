using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    void Start()
    {
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other)
    {
        Bullet bullet = other.gameObject.GetComponent<Bullet>();
        if (bullet !=null)
        {
            Health -= bullet.damage;
        }
        if (Health <1)
        {
            Die();
        }
    }
}
