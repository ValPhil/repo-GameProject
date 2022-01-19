using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool isOpen = false;
    float rotation = 0f;

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && other.gameObject.GetComponent<Status>().HasRedKey == true && isOpen == false)
        {
            //transform.localRotation = Quaternion.Euler(0, -90, 0);
            isOpen = true;
        }
    }
    private void Update()
    {
        if(rotation <= -89)
        {
            rotation = -90;
        }
        if (isOpen == true && rotation >= -89)
        {
            rotation -= 30 * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, rotation, 0);
        }
    }    
}
