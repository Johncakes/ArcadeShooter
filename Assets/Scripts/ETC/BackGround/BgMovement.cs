using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    Rigidbody2D rb; 

    public int bgspeed;

    void Start() 
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -bgspeed);
    }

    void destroyobject()
    {
        Destroy(gameObject);
    }
}
