using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float z;
    public float x;
    public float speed;
    public CharacterController playerController;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");     
    }

    void FixedUpdate()
    {
        Vector3 move = transform.right * x + transform.forward * z;
        playerController.Move(move*speed*Time.deltaTime);
    }
}
