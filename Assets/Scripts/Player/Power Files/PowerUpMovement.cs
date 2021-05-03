using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    public float timeBeforeDecay;
    float CurrentTime = 0;
    public int ySpeed;
    int ySpeedState = 0; // 0 for pos, 1 for negative.

    public int xSpeed;
    public Rigidbody2D powerRb;
    void Start()
    {
       
        ySpeedState= Random.Range(0,2);
                if(ySpeedState != 0)
        {
            xSpeed = -xSpeed;
        }
        movePowerDir();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == ("Wall X axis"))
        {
            xSpeed = -xSpeed;
            movePowerDir();
        } 
        if (other.tag == ("Wall Y axis"))
        {
            ySpeed = -ySpeed;
            movePowerDir();
        }    
    }
    void Update() 
    {
        CurrentTime += Time.deltaTime;

        if(CurrentTime >= timeBeforeDecay)
        {
            Destroy(gameObject);
        }
        //Debug.Log(CurrentTime);
    }

    void movePowerDir()
    {

        powerRb.velocity = new Vector2(xSpeed,ySpeed) ;
    }
}
