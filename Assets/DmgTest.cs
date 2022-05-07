using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgTest : MonoBehaviour
{
    PlayerHealth PlayerHealth;
    public int dmg = 10;
     void Start ()
    {
        
    }

     void OnTriggerEnter(Collider other) 
    {
          PlayerHealth = other.transform.GetComponent<PlayerHealth>();
          
    
        if (other.gameObject.tag == "Player")
        {
        PlayerHealth.DamagePlayer(dmg);
        Debug.Log("DMG Taken");
        Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 10f);
        }

    }








}
