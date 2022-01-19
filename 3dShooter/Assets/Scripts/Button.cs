using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject portal;
    //public Collider collider;

    private void Start()
    {
        portal.SetActive(false);    
    }
    private void OnTriggerStay(Collider other)
    {
    
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy")
        {
            portal.SetActive(true);
        }
    
    }
    private void OnTriggerExit(Collider other)
    {
        portal.SetActive(false);
    }

    void Update()
    {
        
    }
}
