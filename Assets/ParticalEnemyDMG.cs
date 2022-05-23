using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalEnemyDMG : MonoBehaviour
{
    public float damage = 10f;



    void OnTriggerEnter(Collider other)
    {

       Enemy Enemy = GetComponent<Enemy>();
        if (Enemy != null)
        {
            Enemy.TakeDamage(damage);
        }

    }




}
