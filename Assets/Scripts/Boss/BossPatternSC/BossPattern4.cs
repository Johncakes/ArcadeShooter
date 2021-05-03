using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPattern4 : MonoBehaviour
{
    public GameObject xksakr4, xksakr4l;
    float tlrks, a, x, y;
    bool rigth = false;
    // Start is called before the first frame update
    void Start()
    {
        a = 15;
    }

    // Update is called once per frame
    void Update()
    {
        tlrks += Time.deltaTime;
        if(tlrks >= a)
        {
            if(rigth != true)
            {
                x = Random.Range(-14, -12);
                rigth = true;
                Instantiate(xksakr4, new Vector3(x, y, 0), Quaternion.identity);
            }
            else if(rigth == true)
            {
                x = Random.Range(13, 15);
                rigth = false;
                Instantiate(xksakr4l, new Vector3(x, y, 0), Quaternion.identity);
            }
            y = Random.Range(-6, 4);
            tlrks = 0;
            a -= 0.05f;
        }
    }
}
