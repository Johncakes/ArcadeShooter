using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerPattern : MonoBehaviour
{
    public GameObject trackerBullet;
    [SerializeField] Transform bossLeftSide, bossRightSide;
    [SerializeField] private int totalBulletAmount;
    [SerializeField] private float spawnDelay;
    

    BossMain bossMain;
    private void Start() 
    {
        bossMain = GetComponent<BossMain>();
    }
    public void PatternCalled()
    {
        //Debug.Log("Tracker pattern Called");
        StartCoroutine(ShootTracker());
    }

    IEnumerator ShootTracker()
    {
        for (int i = 0; i < totalBulletAmount; i++)
        {
            //Debug.Log("Spawned Tracker!");
            Instantiate(trackerBullet,bossLeftSide.position, Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(spawnDelay);
        }
        
        for (int i = 0; i < totalBulletAmount; i++)
        {
            Instantiate(trackerBullet,bossRightSide.position, Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(spawnDelay);
        }

        //Debug.Log("Skipped for loop");
        yield return new WaitForSeconds(4f);
        bossMain.SetPatterAvailable();    
    }

}



