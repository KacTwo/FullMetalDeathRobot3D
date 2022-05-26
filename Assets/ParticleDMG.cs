using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDMG : MonoBehaviour
{
    PlayerHealth PlayerHealth;
    public int dmg = 10;
    private float phealth = 1;

     void Start ()
    {
        
    }

     void OnTriggerEnter(Collider other) 
    {
          PlayerHealth = other.transform.GetComponent<PlayerHealth>();
          
    
        if (other.gameObject.tag == "Player")
        {
        PlayerHealth.DamagePlayer(dmg);
       // Debug.Log("DMG Taken");
        Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 10f);
        }

    }

    public void DestroyParticle(float amount) //niiedzia³a //
    {
        //czekaj dodanie taga enemy do tego me¿e zadzia³a
        phealth -= amount;
        if (phealth <= 0f)
        {
            dietwo();
        }
    }

    void dietwo()   // nie printuje w konsoli :c
    {
        Destroy(gameObject);
        Debug.Log("particle znniszczony");
    }




}
