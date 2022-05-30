using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    float DHealth = 1f;
    public ParticleSystem DestructionParticle;
    public AudioClip DestructionSound;

    public void Destruction(float damount)
    {
        DHealth -= damount;

        if (DHealth <= 0f)
        {

            DestructionParticle.Play();
            SoundMenager.instance.Play(DestructionSound);
            Destruct(); 

        }

    }



    void Destruct()
    {

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
