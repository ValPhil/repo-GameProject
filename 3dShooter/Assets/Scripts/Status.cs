using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public int MaxMana;
    public int MaxHealth;
    public int Health;
    public int Mana;
    public bool HasRedKey = false;
    float t = 0f;

    void Start()
    {
        Health = MaxHealth;
        Mana = MaxMana;
    }

    
    void Update()
    {
        t += Time.deltaTime;
        if (t >=1 && Mana < MaxMana)
        {
            Mana += 10;
            t = 0;
        }
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        if (Mana > MaxMana)
        {
            Mana = MaxMana;
        }        
        if (Health < 1)
        {
            die();
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        EnemyBullet bullet = other.gameObject.GetComponent<EnemyBullet>();
        if (bullet != null)
        {
            Health -= bullet.damage;
        }
        if (other.gameObject.tag == "Portal")
        {            
            SceneManager.LoadScene(other.gameObject.GetComponent<Portal>().nextLevel);
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "lava")
        {            
                Health = 0;
        }
    }
    
    public void die()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene(0);
    }
}
