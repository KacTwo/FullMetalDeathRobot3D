using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIeICoinsy : MonoBehaviour
{
    [SerializeField] float coinValue = 100;
    [SerializeField] float health = 1;
    [SerializeField] float deathtime = 2f;
    [SerializeField] public ParticleSystem deathParticle;
    [SerializeField] public AudioClip deathSound;
    //[SerializeField] public AnimationClip deathAnimation;
    //[SerializeField] public Animation anim;
    // animacje nie dizalaja, nie mam sily walczyc z nimi 
    void Start()
    {
       
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore += coinValue;
            Die(); //dodaje scora
        }
    }
    void Die()
    {
        deathParticle.Play();
        SoundMenager.instance.Play(deathSound);
        //anim.Play("deathAnimation");//animacje
        Debug.Log("umar");
        Destroy(gameObject, deathtime);
    }

}
