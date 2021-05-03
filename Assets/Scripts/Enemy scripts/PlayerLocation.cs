using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{

    GameObject target = GameObject.FindGameObjectWithTag("Player");

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = target.transform.position;
    }
}
