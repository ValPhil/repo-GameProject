using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public bool isCarring = false;
    public bool isInRange = false;
    public GameObject player;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInRange = false;
        }
    }    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRange == true && isCarring == false)
        {
            isCarring = true;
            transform.SetParent(player.transform);
        }
        else
        if (Input.GetKeyDown(KeyCode.E) && isCarring == true)
        {
            isCarring = false;
            transform.SetParent(null);
            transform.position += new Vector3(0,1,0);
        }
        if (isCarring == true)
        {
            transform.position = Vector3.Lerp(transform.position,player.transform.position+ player.transform.forward*3,Time.deltaTime);
        }
    }
}
