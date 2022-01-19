using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject player;
    public Text StatsText;
    public Text AmmoText;
    private int HP;
    private int MP;
    private Status Mystats;
    void Start()
    {
        Mystats = player.GetComponent<Status>();
        HP = Mystats.Health;
        MP = Mystats.Mana;
    }

    // Update is called once per frame
    void Update()
    {
        HP = Mystats.Health;
        MP = Mystats.Mana;
        StatsText.text = "HP: "+ HP+ "/"+ Mystats.MaxHealth + "\n" + "MP: " + MP + "/" + Mystats.MaxMana;

        if (Input.GetKey(KeyCode.Alpha1))
        {
            AmmoText.text = "Fire";
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            AmmoText.text = "Ice";
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            AmmoText.text = "Air";
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            AmmoText.text = "Earth";
        }







    }
}
