﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Rigidbody controller;
    public Collider collider;
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
        controller.velocity = transform.forward * y * speed + transform.right * x * speed;// - transform.up*9.8f;

        
        
        
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            falling.y = 0F;
        }
    }
}