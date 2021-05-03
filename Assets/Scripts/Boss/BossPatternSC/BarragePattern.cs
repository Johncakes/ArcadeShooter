using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarragePattern : MonoBehaviour
{
    int b = -100;
    [SerializeField] private GameObject barrageBullet;
    [SerializeField] private Transform spawnPoint;
    float timeA = 0;
    bool check = true;
    int count = 0;
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void PatternCalled()
    {
        
    }
    void Update()
    {
        timeA = timeA + Time.deltaTime;
        if(timeA >= 0.3f)
        {
            Pattern1();
            timeA = 0;
            if (check == true)
            {
                b = b + 50;
            }
            else
            {
                b = b - 50;
            }
            if (b == 100)
            {
                check = false;
            }
            else if(b == -100)
            {
                check = true;
            }
        }
        if(count == 17)
        {
            count = 0;
            gameObject.SetActive(false);
        }
    }

    void Pattern1()
    {
        for (int x = -12; x <= 12; x = x + 3)
        {
            Instantiate(barrageBullet, transform.position, Quaternion.Euler(0, 0, ((40 * x) + b) / 10));
        }
        count++;
    }

}
