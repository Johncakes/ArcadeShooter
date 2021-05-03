using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    Attack attack;
    private void Start()
    {
        attack = GameObject.FindGameObjectWithTag("Player").GetComponent<Attack>();
        
    }
    private void OnTriggerEnter2D(Collider2D player) 
    {
        if(player.tag == ("ItemCollider"))
        {
            attack.LevelUp();       
            Destroy(gameObject);
        }
    }
}
