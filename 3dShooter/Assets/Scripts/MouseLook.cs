using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensivity;
    public Transform body;
    public float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

        xRotation -= mouseY;
        if (xRotation>90f)
        {
            xRotation = 90f;
        }
        if(xRotation < -90f)
        {
            xRotation = -90f;
        }


        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        body.Rotate(Vector3.up * mouseX);
    }
}
