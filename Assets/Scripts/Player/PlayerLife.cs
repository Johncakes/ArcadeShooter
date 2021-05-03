
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{   
    GameManager gm;
    Attack attack;
    public int life;
    public float invincibility_time;
    public float timeBeforeRespawn;
    public GameObject respawnPoint;
    public GameObject mainPlayer;
    public GameObject playerShield;
    public GameObject itemCollider;
    private SoundManager sound;

    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        sound = FindObjectOfType<SoundManager>();
        attack = GameObject.FindGameObjectWithTag("Player").GetComponent<Attack>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == ("EnemiesAttack") && gm.developerState() == false) //적의 공격에 맞았을 때
       {
           OnDamaged();
       }
       else if (other.tag == ("Enemies") && gm.developerState() == false) //적이랑 부딪혔을 때
       {
           OnDamaged();
       }
    }

    void OnDamaged() //맞았을 때 작동되는 함수
    {
        life--;

        explode();
        Invoke("respawn", timeBeforeRespawn);

        invincibility();
        Invoke("shieldsUp", timeBeforeRespawn);
        Invoke("off_Invincibility", timeBeforeRespawn + invincibility_time);
        gm.lifeDecrease(life);
        gm.fire();
        
        sound.Play("Dead");
        
         attack.playerLevelReset();
       
        if (life == 0)
        {
            gm.PlayerDeath();
        }
    }

    void respawn()
    {
        mainPlayer.transform.position = respawnPoint.transform.position;
        mainPlayer.GetComponent<SpriteRenderer>().enabled = true;
        itemCollider.GetComponent<Collider2D>().enabled = true;
        itemCollider.GetComponent<CapsuleCollider2D>().enabled = true;
        gm.fire();
    }
    void invincibility()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        itemCollider.GetComponent<BoxCollider2D>().enabled = false;
        itemCollider.GetComponent<CapsuleCollider2D>().enabled = false;
        
       //Debug.Log("Invincible!");
    }

    void shieldsUp()
    {
        playerShield.GetComponent<SpriteRenderer>().enabled = true;
    }

    void off_Invincibility()
    {
        gameObject.GetComponent<Collider2D>().enabled = true;
        
        playerShield.GetComponent<SpriteRenderer>().enabled = false;
        //Debug.Log("Not Invincible!");
    }
    void explode()
    {
        mainPlayer.GetComponent<SpriteRenderer>().enabled = false;

        var ps = GetComponentInChildren<ParticleSystem>();
            for(int i = 0; i <2; i++)
            {
                //Debug.Log("Boom!");
                ps.Play();
            }

        

    }

}

