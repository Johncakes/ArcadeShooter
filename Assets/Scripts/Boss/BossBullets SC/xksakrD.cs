using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xksakrD : MonoBehaviour
{
    float x, y;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = Random.Range(-14, -3) - transform.position.y;
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(x, y) * Mathf.Rad2Deg);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 12 * Time.deltaTime, 0);
        if(Mathf.Abs(transform.position.y) > 20)
        {
            Destroy(gameObject);
        }
    }
}
