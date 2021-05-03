using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPattern2 : MonoBehaviour
{
    public GameObject xksakr2;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        for(int a = 0; a < 2; a++)
        {
            Instantiate(xksakr2, transform.position, Quaternion.Euler(0, 0, 0));
        }
        gameObject.SetActive(false);
    }
}
