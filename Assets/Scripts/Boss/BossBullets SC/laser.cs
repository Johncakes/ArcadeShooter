using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    float tlrks = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tlrks += Time.deltaTime;
        if(tlrks > 0.4)
        {
            Destroy(gameObject);
        }
    }
}
