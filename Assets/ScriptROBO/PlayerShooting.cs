using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
   
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;
    public GameObject ImpactEffect;

    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot ()
    {



        MuzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy Enemy = hit.transform.GetComponent<Enemy>();
            if (Enemy != null)
            {
                Enemy.TakeDamage(damage);
            }
            Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
