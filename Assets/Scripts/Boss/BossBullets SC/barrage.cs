using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrage : MonoBehaviour
{
    public float speed = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
        if(Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16)
        {
            Destroy(gameObject);
        }
    }
}
