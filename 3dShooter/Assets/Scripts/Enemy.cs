using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetDamage(int damage) 
    {
        Health -= damage;
        if (Health <1)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }

}
