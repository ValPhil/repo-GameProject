using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Rigidbody controller;    
    public float speed;    
    bool isJumping = true;
    public float gravity = -0.8f;
    private Vector3 falling;
    void Start()
    {
        
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        controller.velocity = transform.forward * y * speed + transform.right * x * speed;

        
        
        
        if (Input.GetButtonDown("Jump")&& isJumping == false)
        {
            isJumping = true;
            falling.y = 0.2F;
        }

    }
    void FixedUpdate()
    {
        if (isJumping == true)
        {
            transform.position += falling;
        }

        falling.y += gravity * Time.deltaTime;
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isJumping = false;
            falling.y = 0F;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isJumping = true;
    }    
}
