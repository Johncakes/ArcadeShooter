using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMgame : MonoBehaviour
{
    public AudioClip field_1, field_2, boss_1, boss_2, danger, claer;
    private AudioSource sound;
    bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    public void field()
    {
        StartCoroutine("PlaylistField");
    }

    public void boss()
    {
        StartCoroutine("PlaylistBoss");
    }

    public void Claer()
    {
        StopAllCoroutines();
        sound.clip = claer;
        sound.Play();
    }

    IEnumerator PlaylistField()
    {
        sound.clip = field_1;
        sound.Play();
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if (!sound.isPlaying)
            {
                sound.clip = field_2;
                sound.Play();
                sound.loop = true;
            }
        }
    }
    IEnumerator PlaylistBoss()
    {
        sound.clip = danger;
        sound.Play();
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if (!sound.isPlaying && b == true)
            {
                sound.clip = boss_1;
                sound.Play();
                b = false;
            }
            while (b != true)
            {
                yield return new WaitForSeconds(0.1f);
                if (!sound.isPlaying)
                {
                    sound.clip = boss_2;
                    sound.Play();
                }
            }
        }
    }
}
