using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPattern : MonoBehaviour
{
    float laserRange, b;
    public GameObject warningLineObject, laserObject;
    [SerializeField] private Transform laserSpawn;
    float time = 0;
    bool isLaserActive = false;
    int laserAmount;
    bool isWarningLineActive = false;
    BossMain bossMain;
    void Start()
    {
        bossMain = GetComponent<BossMain>();
    }
    public void PatternCalled()
    {
        StartCoroutine(shootLaser());
    }

    IEnumerator shootLaser()
    {
        laserAmount = Random.Range(1,6);
        for (int i = 0; i < laserAmount; i++)
        {
            laserRange = Random.Range(-6.0f, 6.0f);
            Instantiate(warningLineObject, new Vector3(laserRange, laserSpawn.position.y, 0), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(0.9f);

            Instantiate(laserObject, new Vector3(laserRange, laserSpawn.position.y, 0), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("==========Laser Pattern finished!=========");
        bossMain.SetPatterAvailable();
    }
}
