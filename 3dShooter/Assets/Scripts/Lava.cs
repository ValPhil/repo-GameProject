using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private int damage = 5;
    bool isInLava = false;
    void OnCollisionstay(Collision other)
    {
        isInLava = true;        
    }
}
