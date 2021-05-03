using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy001 : MonoBehaviour
{
    public float speed = 10; // speed 라는 변수를 선언한다.
    public int health;
    bool EnemyAliveState = true;
    public int scorePoint;

    GameManager gm;

    Vector3 dir;

    void OnHit(int bullet_Damage)
    {
        health -= bullet_Damage;


        if (health <= 0 && EnemyAliveState == true)
        {

            explode();
            gm.scoreUp(scorePoint);
            //speed = 0;
            Destroy(gameObject, 1.0f);

        }
    }

        void OnTriggerEnter2D(Collider2D collision)
    {
            if (Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16)
                Destroy(gameObject);

            else if (collision.gameObject.tag == "PlayerBullet")
            {
                Bullet bullet = collision.gameObject.GetComponent<Bullet>(); // 아마도 인스펙터창에 컴포넌트 설정하는거겠지?
                OnHit(bullet.bullet_Damage);
                Destroy(collision.gameObject);
            }
        



    }


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        if(gm.playerState() == true)
        {
        int randValue = UnityEngine.Random.Range(0, 10); // 0부터 9까지의 임의의 수 할당

        if (randValue < 4)// 만약 위에서 뽑은 숫자가 3보다 작다고 하면,
        {
            GameObject target = GameObject.FindGameObjectWithTag("Player"); // 플레이어위치를 찾아 타겟으로 설정하기

            dir = target.transform.position - transform.position; // 플레이어위치의 벡터 - 나(Enemy001)의 벡터

            dir.Normalize(); // 단위화 방향의 크기를 1로 설정한다.
        }
        else // 3보다 크면 그냥 아래로 떨어져라

        {
            dir = Vector3.down;  //아래로 떨어지는 움직임 설정
        }

        }
    }


    
    void Update()
    {
        
        transform.position += dir * speed * Time.deltaTime;

        
        if (Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16) 
            Destroy(gameObject); //시야 밖에서 Enemy001 사라진다.
        }

   // private void OnCollisionEnter(Collision other)
    
       // Destroy(other.gameObject);
      //  Destroy(gameObject);

    void explode()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        EnemyAliveState = false;

        var ps = GetComponentInChildren<ParticleSystem>();
            for(int i = 0; i <2; i++)
            {
              //Debug.Log("Boom!");
                ps.Play();
            }

    }


}






// Enemy001은 위에서 아래로 떨어지는 게임오브젝트

//

