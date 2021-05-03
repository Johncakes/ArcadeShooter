using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimation : MonoBehaviour
{
    public Animator Boss;
    public BossHP hp;
    float a = 0;

    // Start is called before the first frame update
    void Start()
    {
        hp = FindObjectOfType<BossHP>();
    }

    // Update is called once per frame
    void Update()
    {
        Boss.SetFloat("HP", hp.currentHP);
        a -= Time.deltaTime;
        //Boss.SetBool("hit", false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerBullet" && a < 0)
        {
            Boss.SetBool("hit", true);
            a = 0.5f;
        }
    }
}
