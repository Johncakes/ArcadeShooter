using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UIElements;
//using UnityEditorInternal;
using UnityEngine;

public class ENEMIESmanager : MonoBehaviour
{
    
    public GameObject[] EnemyObjects;
    public Transform[] spawnLocations;

    public float MaxTime; 
    public float CurrentTime;

    public float StartTime;
    public float EndTime;
    public GameObject player;
   // public Transform look;

    //GameObject target = GameObject.Find("Player");
    //GameObject target = GameObject.FindGameObjectWithTag("Player");





    void Update()
    {
        CurrentTime += Time.deltaTime;

        if(CurrentTime >  MaxTime)
        {
            SpawnEnemy();
            MaxTime = Random.Range(StartTime, EndTime);
            CurrentTime = 0;
        }
    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, 3);
        int ranLocation = Random.Range(0, 5);
        GameObject enemy = Instantiate(EnemyObjects[ranEnemy],
            spawnLocations[ranLocation].position,
            spawnLocations[ranLocation].rotation);
        Rigidbody2D rigid = enemy.GetComponent<Rigidbody2D>();
        ENEMIES enemyLogic = enemy.GetComponent<ENEMIES>();
        enemyLogic.player = player;
        //enemyLogic.look = look;



        if (ranLocation == 0 || ranLocation == 1 || ranLocation == 2 || ranLocation == 3 || ranLocation == 4)  // Right Side Spawner
        {

            rigid.velocity = new Vector2(0, enemyLogic.speed * -1); // Front Side Spawner

        }

            /*

            if ( ranLocation == 1 || ranLocation == 3)  // Right Side Spawner
            {
                //rigid.velocity = new Vector2(enemyLogic.speed * (-1), -0.3f);
                rigid.velocity = new Vector2(0, enemyLogic.speed * -1); // Front Side Spawner

            }
            else if (ranLocation == 5 || ranLocation ==6) //Left Side Spawner
            {
                //rigid.velocity = new Vector2(enemyLogic.speed , -0.3f);
                rigid.velocity = new Vector2(0, enemyLogic.speed * -1); // Front Side Spawner

            }
            else 
            {
                rigid.velocity = new Vector2(0, enemyLogic.speed * -1); // Front Side Spawner
            }

            */




        }

}
