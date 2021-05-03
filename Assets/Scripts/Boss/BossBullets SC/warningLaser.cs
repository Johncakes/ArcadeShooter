using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warningLaser : MonoBehaviour
{
    [SerializeField] float timeBeforeDecay;
    float time = 0;
    bool shouldPlaySound = true;
    static SoundManager sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }

    void Update()
    {
        
        time += Time.deltaTime;
        if(time > 0.4 && shouldPlaySound == true)
        {
            sound.Play("Laser");
            shouldPlaySound = false;
        }
        if(time > timeBeforeDecay)
        {
            Destroy(gameObject);
        }
        
    }
}
