using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            other.gameObject.GetComponent<Status>().Health += 30;
            Destroy(gameObject);
        }
    }
}
