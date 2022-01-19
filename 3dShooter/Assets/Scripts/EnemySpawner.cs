using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        Instantiate(enemy, GameObject.FindGameObjectWithTag("PatrolWaypoints").transform.GetChild(0).position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
