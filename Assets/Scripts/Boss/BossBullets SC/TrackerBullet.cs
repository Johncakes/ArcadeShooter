using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerBullet : MonoBehaviour
{
    float x, y, b;
    float a = 50f;
    bool cpzm = true;
    public GameObject Player;
    private Vector3 velocity = Vector3.zero;
    float tlrks = 0;
    // Start is called before the first frame update
    void Start()
    {
        b = 0;
        x = Random.Range(-10, 10);
        y = Random.Range(13, 15);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        tlrks += Time.deltaTime;
        if(tlrks > 0.3)
        {
            b++;
            tlrks = 0;
        }
        if(cpzm == true)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(x, y, 0), ref velocity, 2f);
            transform.Rotate(new Vector3(0, 0, a));
            a -= 0.35f;
        }
        if(a < 0.5f && cpzm == true)
        {
            cpzm = false;
            //Debug.Log(tlrks);
        }
        if(cpzm == false && b <= 7 && Player != null)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180 - (Mathf.Rad2Deg * Mathf.Atan2(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y))));
        }
        if(b >= 9)
        {
            transform.Translate(0, - 40 * Time.deltaTime, 0);
        }
        if (Mathf.Abs(transform.position.x) > 12 || transform.position.y < -16)
        {
            Destroy(gameObject);
        }
    }
}
