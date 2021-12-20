using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool isOpen = false;
    float rotation = 0f;

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && other.gameObject.GetComponent<Status>().HasRedKey == true)
        {
            //transform.localRotation = Quaternion.Euler(0, -90, 0);
            isOpen = true;
        }
    }
    private void Update()
    {
        if(rotation <= -90)
        {
            rotation = -90;
        }
        if (isOpen == true)
        {
            rotation -= 30 * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, rotation, 0);
        }
    }
}
