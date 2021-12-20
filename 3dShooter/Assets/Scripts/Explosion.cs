using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Vector3 caboom;
    public float grow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(grow,grow,grow)* Time.deltaTime;
        if (transform.localScale.x > 8)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.GetDamage(3);
        }

    }
}
