using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    float offsetX;
    float offsetY;
    public int Charspeed;
    private Vector3 playerPos;
    public FloatingJoystick joystick; 
    Player_Animation player_Anim_class;
    
    //private Vector2 movedirection = Vector2.zero;
    private void Start()
    {
        player_Anim_class = gameObject.GetComponent<Player_Animation>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Debug.Log("Screen Touched!");
            Vector2 pos = Camera.main.ScreenToWorldPoint(touch.position);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    offsetX = pos.x - transform.position.x;
                    offsetY = pos.y - transform.position.y;
                    break;
            
                case TouchPhase.Moved:
                    rb.MovePosition(new Vector3(pos.x - offsetX, pos.y - offsetY));
                    break;
            }
        }
        

    }
}
