/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdef : MonoBehaviour
{
    public string EnemyName;
    public float speed;
    public int health;
    public Animation[] animes;
    Animation animator;

   
      public float maxTime = 3;
    public float minTime = 1;
    public float maxShotDelay = 6;
    public float curShotDelay = 1;
    


    
    public GameObject bulletObjA; //v
    public GameObject bulletObjB; //v
    public GameObject bulletObjC;
    public GameObject player; //
    //public Transform look; //


    /////public GameObject target = GameObject.Find("Player");









    void ReturnAnimation()
    {
        animator.Animator = animes[0];
        
    }

    void Awake()
    {
        animator = GetComponent<Animator>();

    }
    
    void Update()
    {
        //curShotDelay += Time.deltaTime;
        Fire();
        Reload();
        //maxShotDelay = UnityEngine.Random.Range(minTime, maxTime);

    }
    

    
    void start()
    {
        maxShotDelay = UnityEngine.Random.Range(minTime, maxTime);
        
    }
    
    void Fire()
    {

        //public GameObject target = GameObject.FindGameObjectWithTag("Player");

        if (curShotDelay < maxShotDelay)
            return;
        if (EnemyName == "Triangle")
        {
            GameObject bullet = Instantiate(bulletObjA, transform.position, Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(player.transform.position.x - transform.position.x, transform.position.y-player.transform.position.y) * Mathf.Rad2Deg)));
            Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
            Vector3 dirVec = player.transform.position - transform.position;
            rigid.AddForce(dirVec.normalized * 20, ForceMode2D.Impulse);
            //this.transform.LookAt(look);

            //curShotDelay = 0;
            // maxShotDelay = UnityEngine.Random.Range(minTime, maxTime);
        }

        if (EnemyName == "Propeller")
        {
            GameObject bullet = Instantiate(bulletObjC, transform.position, Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(player.transform.position.x - transform.position.x, transform.position.y - player.transform.position.y) * Mathf.Rad2Deg)));
            Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
            Vector3 dirVec = player.transform.position - transform.position;
            rigid.AddForce(dirVec.normalized * 20, ForceMode2D.Impulse);
            //this.transform.LookAt(look);

            //curShotDelay = 0;
            //maxShotDelay = UnityEngine.Random.Range(minTime, maxTime);
        }

        if (EnemyName == "Circle")
        {
           
            GameObject bulletR = Instantiate(bulletObjB, transform.position + Vector3.right* 0.7f, transform.rotation);
            GameObject bulletL = Instantiate(bulletObjB, transform.position + Vector3.left* 0.7f, transform.rotation);

            Rigidbody2D rigidR = bulletR.GetComponent<Rigidbody2D>();
            Rigidbody2D rigidL = bulletL.GetComponent<Rigidbody2D>();

            
            Vector3 dirVecR = player.transform.position - transform.position + (Vector3.right * 0.7f);
            Vector3 dirVecL = player.transform.position - transform.position + (Vector3.left * 0.7f);

            rigidR.AddForce(dirVecR.normalized * 20, ForceMode2D.Impulse);
            rigidL.AddForce(dirVecL.normalized * 20, ForceMode2D.Impulse);
            //this.transform.LookAt(look);

            //curShotDelay = 0;
            //maxShotDelay = UnityEngine.Random.Range(minTime, maxTime);
        }

        curShotDelay = 0;
    }

    void Reload()
    {
        curShotDelay += Time.deltaTime;
    }
    





    void OnHit(int bullet_Damage)
    {
        health -= bullet_Damage;
        spriteRenderer.sprite = sprites[2];
        Invoke("ReturnSprite", 0.1f);

        if (health <= 0)
        {
            Destroy(gameObject);
        }

      
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16)
            Destroy(gameObject);

        else if(collision.gameObject.tag == "PlayerBullet")
        {
            Bullet bullet = collision.gameObject.GetComponent<Bullet>(); // 아마도 인스펙터창에 컴포넌트 설정하는거겠지?
            OnHit(bullet.bullet_Damage);
            Destroy(collision.gameObject);
        }
        if (Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16)
        {
            Destroy(gameObject);

        }


    }

    



}

*/


    
    

    
