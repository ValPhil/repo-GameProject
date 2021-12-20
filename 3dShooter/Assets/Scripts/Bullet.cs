using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    public int damage;
    
    float speed = 30f;
    void Start()
    {        
    }
        
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision other)
    {        
        Destroy(gameObject);        
    }
}
