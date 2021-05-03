using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPatternl : MonoBehaviour
{
    float b = -200;
    public GameObject xksakr1;
    float timeA = 0;
    bool cpzm = true;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeA = timeA + Time.deltaTime;
        if(timeA >= 0.8)
        {
            Pattern1();
            timeA = 0;
            b += 24.5f;
        }
        if(count == 17)
        {
            count = 0;
            gameObject.SetActive(false);
        }
    }

    void Pattern1()
    {
        for (int x = -20; x <= 20; x = x + 5)
        {
            Instantiate(xksakr1, transform.position, Quaternion.Euler(0, 0, ((40 * x) + b) / 10));
        }
        count++;
    }
}
