using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalEnemyDMG : MonoBehaviour
{
    public float damage = 10f;
    DIeICoinsy DIeICoinsy; // Powiedzmy, że deklarujesz iż korzystasz z klasy Enemy i nazywasz ją Enemy


    void OnTriggerEnter(Collider other)
    {

        DIeICoinsy = other.transform.GetComponent<DIeICoinsy>(); // Tutaj zaciągasz komponenty  Czyli Enemy to Enemy w sumie


        if (other.gameObject.tag == "Enemy")
        {
            DIeICoinsy.TakeDamage(damage); // i tutaj korzystasz z Funkcji która jest w klasie Enemy. 
            damage -= Time.deltaTime;
            //Debug.Log("WaveDMG"); //pojawia się w logu

            

        }

       

    }




}
