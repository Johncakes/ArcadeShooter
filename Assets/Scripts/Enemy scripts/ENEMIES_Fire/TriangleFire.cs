using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleFire : MonoBehaviour
{

    

    float currentTime; // 현재 시간을 선언한다.

    public float minTime = 2f; // 최소시간
    public float maxTime = 4; // 최대시간f

    public float createTime = 1; // 일정 시간(생성되는 시간)을 선언한다. (생성 시간을 랜덤으로 하게되어 현재 시간 고정은 이제 의미가 없다.
    public GameObject TriBulletFactory;
    public GameObject triangleFire;

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
        



    }


    void Update()
    {
        
        

        currentTime += Time.deltaTime; // 시간이 계속 흐른다.

        if (currentTime > createTime) // 현재 시간이 일정 시간이 되면(여기서는 초과한다고 구현한다.)
        {
            GameObject triBullet = Instantiate(TriBulletFactory);

            triBullet.transform.position = triangleFire.transform.position;
            

            currentTime = 0; 

            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }

    }

}
