using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject GunCannon1;
   
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;
    public GameObject ImpactEffect;
    public float impactforce = 30f;
    public float Firerate = 15f;
    private float nextTimeToFire = 0f;
    public AudioClip ShootSound;

    void Update()
    {

        if(Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            GunCannon1.GetComponent<Animator>().Play("ShootCannon");
            SoundMenager.instance.Play(ShootSound);
            nextTimeToFire = Time.time + 1f / Firerate;
            Shoot();
            GunCannon1.GetComponent<Animator>().Play("Idle");
        }
    }
    void Shoot ()
    {

        // gracz strzela animacja
       
        
        MuzzleFlash.Play();
        GunCannon1.GetComponent<Animator>().Play("Idle");

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            /*
            Enemy Enemy = hit.transform.GetComponent<Enemy>();
            if (Enemy != null)
            {
                Enemy.TakeDamage(damage);
            }
            */



            DIeICoinsy DIeICoinsy = hit.transform.GetComponent<DIeICoinsy>();
            if (DIeICoinsy != null)
            {
                DIeICoinsy.TakeDamage(damage);
            }

            Destructible Destructible = hit.transform.GetComponent<Destructible>();
            if (Destructible != null)
            {
                Destructible.Destruction(damage);
            }










            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal*impactforce);
            }

           GameObject ImpactGo = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
           Destroy(ImpactGo, 2f);
        }
        
    }
}
