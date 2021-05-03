using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation : MonoBehaviour
{
    public Animator anim;
    Rigidbody2D rb;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Velocity", rb.velocity.x);
       // anim.SetBool("IsLeft", false);
    }

    /*
    public void turnRight()
    {
        anim.SetBool("IsStill",false);
        anim.SetBool("IsRight", true);
        Debug.Log("Right");
    }
    public void turnLeft()
    {
        anim.SetBool("IsStill",false);
        anim.SetBool("IsLeft", true);
        Debug.Log("Left");
    }
    public void still()
    {
        anim.SetBool("IsRight",false);
        anim.SetBool("IsLeft", false);

        anim.SetBool("IsStill",true);
    
    }
    */
}
