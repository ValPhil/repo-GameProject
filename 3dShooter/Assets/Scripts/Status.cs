using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public int MaxMana;
    public int MaxHealth;
    public int Health;
    private int Mana;
    public bool HasRedKey = false;

    void Start()
    {
        Health = MaxHealth;
        Mana = MaxMana;
    }

    
    void Update()
    {
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        if (Mana > MaxMana)
        {
            Mana = MaxMana;
        }
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
            Debug.Log("Death");
        }
    }
}
