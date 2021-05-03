using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerHit : MonoBehaviour
{ 

    private Animator anime;


    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }
    
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //anime.SetBool("isHit", true);
        if (collision.tag == "PlayerBullet")
        {
            anime.SetBool("isHit", true);
            return;
        }

        else
           anime.SetBool("isHit", false);
    }
*/    

    /*

    // Update is called once per frame

         private void OnTriggerEnter(Collider collision)
        {

            if (collision.gameObject.tag == "PlayerBullet")
            {
                Bullet bullet = collision.gameObject.GetComponent<Bullet>();
                anime.SetBool("isHit", true);


               

            }
            
        }
    */

}
   