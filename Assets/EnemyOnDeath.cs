using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOnDeath : MonoBehaviour
{
    public int chance;
    public int coinChance;
    
    public GameObject powerUp;
    public GameObject coin;
    
    
    int rng;

    public void spawnCoin()
    {
       rng = Random.Range(0,coinChance);
        if (rng == 1)
        {
         Instantiate(coin , transform.position, transform.rotation);
        }    
    }
    public void spawnPowerUp()
    {
        rng = Random.Range(0,chance + 1);
        if (rng == 1)
        {
         Instantiate(powerUp , transform.position, transform.rotation);
        }
    }
}
