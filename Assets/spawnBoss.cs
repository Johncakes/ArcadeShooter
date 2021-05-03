using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bossSpawnPoint;
    public Transform bossHealthSpawnPoint;
    public GameObject bossPrefab;
    public GameObject bossHealthPrefab;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.K))
      {
        Debug.Log("Boss Spawn!");
        Instantiate(bossPrefab, bossSpawnPoint.transform.position, bossSpawnPoint.rotation);
        Instantiate(bossHealthPrefab, bossHealthSpawnPoint.transform.position, bossHealthSpawnPoint.rotation);
      }
    }
    
  
    
}
