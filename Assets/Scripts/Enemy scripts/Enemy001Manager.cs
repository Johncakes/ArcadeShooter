using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy001Manager : MonoBehaviour
{

    //Enemy001Manager : Enemy001Manager 게임오브젝트를 생성하게 하는 곳.

    // 목적 : 특정 시간이 지날 때 마다 Enemy001을 하나씩 생성한다.
    // 1. 시간이 흐르다가
    // 2. 만약 현재 시간이 일정 시간이 된다면,
    // 3. <적 공장>에서 적을 생성한다. (적 공장을 생성하는 이유는 Pool 개념과 연관이 있다.)

    float currentTime; // 현재 시간을 선언한다.

    public float minTime = 1f; // 최소시간
    public float maxTime = 2.5f; // 최대시간f

    public float createTime = 1; // 일정 시간(생성되는 시간)을 선언한다. (생성 시간을 랜덤으로 하게되어 현재 시간 고정은 이제 의미가 없다.
    public GameObject enemy001Factory; // Enemy001의 공장을 선언한다.

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    
    void Update()
    {
        currentTime += Time.deltaTime; // 시간이 계속 흐른다.

        if (currentTime > createTime) // 현재 시간이 일정 시간이 되면(여기서는 초과한다고 구현한다.)
        {
            GameObject enemy001 = Instantiate(enemy001Factory); //적 공장에서 적을 생성한다. (Instantiate의 기능은 무엇인지 알아보기)

            enemy001.transform.position = transform.position;
            // enemy001의 위치는 이곳(enemy001Manager)의 위치와 같게 설정하며 이 오브젝트 내에서는 자기 자신을 직접 설정할 필요는 없다.

            currentTime = 0; // 현재 시간이 계속 증가하는데 0으로 다시 재설정해줌으로써 연속적으로 enemy001이 생기는 것을 방지하는 목적이다.

            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
