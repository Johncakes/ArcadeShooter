using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSpawner : MonoBehaviour
{
    public GameObject bg;
    void Start()
    {
       // Instantiate(bg, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "BG")
        {
            //Debug.Log("Touch");
            Instantiate(bg, transform.position, transform.rotation);
        }   
              
    }
}
