using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    [SerializeField] private float totalBossHP;
    [SerializeField] public float currentHP;
    Bullet bullet;
    Transform healthBar;
    float healthPercentage;
    private SoundManager sound;
    private BGMgame Gsound;
    void Start()
    {
        currentHP = totalBossHP;
        sound = FindObjectOfType<SoundManager>();
        Gsound = FindObjectOfType<BGMgame>();
        healthBar = GameObject.Find("BossHealth").GetComponent<Transform>();
    }

    void Update()
    {
        healthPercentage = currentHP / totalBossHP;
        if(healthPercentage > 0)
        {
            healthBar.transform.localScale = new Vector3(healthPercentage, 1f, 1f);
        }
        if(currentHP <= 0)
        {
            Destroy(gameObject);
            Gsound.Claer();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerBullet")
        {
            bullet = collision.gameObject.GetComponent<Bullet>();
            currentHP -= bullet.bullet_Damage;
            Destroy(collision.gameObject);
            sound.Play("Shot");
            //Debug.Log("1");
        }
    }
}
