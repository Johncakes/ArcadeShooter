using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int speed;
    public int coinPoint;
    GameManager gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("ItemCollider"))
        {
            gm.scoreUp(coinPoint);
            Destroy(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
