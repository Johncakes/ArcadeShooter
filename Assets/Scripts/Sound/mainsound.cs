using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainsound : MonoBehaviour
{
    public AudioClip _main, _start;
    static AudioSource _source;
    void Start()
    {
        _source = GetComponent<AudioSource>();
        _source.clip = _main;
        _source.Play();
    }

    public void start()
    {
        _source.clip = _start;
        _source.Play();
    }
}
