using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenager : MonoBehaviour
{

    public AudioSource EffectsSource;
    public AudioSource MusicSource;

    public static SoundMenager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Play (AudioClip clip)
    {
        EffectsSource.clip = clip;
        EffectsSource.Play();
    }

    public void PlayMusic (AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }

















}