using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int bullet_Damage;
    public Rigidbody2D Bullet_rb; 

    Attack Attack;
     void Start() 
    {
        Attack = GameObject.FindGameObjectWithTag("Player").GetComponent<Attack>();
        
        switch(Attack.return_Player_Level())
        {
            case 2:
                bullet_Damage = 2;
                break;
            case 3:
                bullet_Damage = 3;
                break;
            default:
                bullet_Damage = 1;
                break;
        }
    
        Bullet_rb.velocity = transform.up * speed;
    }

     void OnTriggerEnter2D(Collider2D collision) 
 {  
        if (collision.gameObject.tag == "BorderBullet")
        {
            Destroy(gameObject);
        }
 }
    
}
