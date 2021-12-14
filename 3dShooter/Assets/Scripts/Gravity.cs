using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity = -9.81f;
    Vector3 move;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.y += gravity* Time.deltaTime;
        transform.position += move*Time.deltaTime; 
    }
}
