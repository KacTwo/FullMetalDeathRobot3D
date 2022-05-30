using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenager : MonoBehaviour
{

    public AudioSource EffectsSource;
    public AudioSource MusicSource;
    private float MusicVolume = 1f;
    private float EffectsVolume = 1f;
  

    public static SoundMenager instance = null;


    private void HoldSM ()
    {
         if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }





    private void Awake()
    {
       HoldSM();
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

     void Update() 
    {
        EffectsSource.volume = EffectsVolume;
        MusicSource.volume = MusicVolume;

    }

    public void updateMvolume (float Mvolume )
    {
        MusicVolume = Mvolume;
    }

    public void updateEvolume (float Evolume )
    {
        EffectsVolume = Evolume;
    }

















}