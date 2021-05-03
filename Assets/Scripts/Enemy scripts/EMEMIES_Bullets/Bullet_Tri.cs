using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Tri : MonoBehaviour
    {


    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16)
            Destroy(gameObject);
    }

     

    }



