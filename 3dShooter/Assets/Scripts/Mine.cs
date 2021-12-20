using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
