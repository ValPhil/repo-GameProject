using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject player;
    public Vector3 way;
    public float speed;
    public int damage = 5;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        way = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += way*speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
