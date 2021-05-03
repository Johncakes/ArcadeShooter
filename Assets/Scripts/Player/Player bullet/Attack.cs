using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public Transform firePoint;
    public BulletSO bullet;
    static SoundManager sound;

    GameManager gm; 
    public float fireRate;
    float lastfired;

    public int Player_Level;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        sound = FindObjectOfType<SoundManager>();
    }
    
    void Update()
    {
        if(gm.playerState() == true)
        {
            if (Time.time - lastfired > 1 / fireRate)
            {
                lastfired = Time.time;
                Shoot();
                sound.Play("Shooting");
            }
        }
        /*
        if (Input.GetKey(KeyCode.Z) && gm.fireState() == true)
        {
        }*/
    }
    
        void Shoot()
        {
            Instantiate(bullet.ReturnBullet(Player_Level -1),firePoint.position,firePoint.rotation);
        }
    

    public int return_Player_Level()
        {
            return Player_Level;
        }
    
    public void LevelUp()
    {
        Player_Level++;
        if (Player_Level > 3)
        {
            Player_Level = 3;
        }
    }
    public void playerLevelReset()
    {
        Player_Level = 1;
    }
}

