
using UnityEngine;
using System;
using UnityEngine.Audio;

public class SoundManager_script : MonoBehaviour
{
    public  Sound[] sounds;
        void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Update is called once per frame
    public void Play (string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
       if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
     void Start()
    {
        Play("ambiance");
    }
}
