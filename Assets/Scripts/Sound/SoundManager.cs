using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;
    public float volume;

    private AudioSource source;

    public void SetSource(AudioSource _source)
    {
        source = _source;
        source.clip = clip;
        source.volume = volume;
    }
    public void Play()
    {
        source.Play();
    }
}

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    public Sound[] sound;

    void Start()
    {
        for(int a = 0; a < sound.Length; a++)
        {
            GameObject soundObject = new GameObject("sound :" + sound[a].name);
            sound[a].SetSource(soundObject.AddComponent<AudioSource>());
            soundObject.transform.SetParent(this.transform);
        }
    }
    
    public void Play(string _name)
    {
        for(int a = 0; a < sound.Length; a++)
        {
            if(_name == sound[a].name)
            {
                sound[a].Play();
                return;
            }
        }
    }
}
