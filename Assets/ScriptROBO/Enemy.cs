using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    // Statistics
    // float health = 50f; //

    // Varibles

    public float gruntValue = 0;

    public NavMeshAgent agent;
    public Transform player;
    public LayerMask WhatIsGround, WhatIsPlayer;
    public GameObject projectile; 
    public AudioClip enemyshoot;

    // Patroling

    public Vector3 WalkPoint;
    bool walkPointSet;
    public float walkPointRange;
    
    // Atacking

    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;



    private void Awake() {


        player = GameObject.Find("FPSRigi").transform;
        agent = GetComponent<NavMeshAgent>();
        
    }


    private void Update() 
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, WhatIsPlayer);
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, WhatIsPlayer);

        if(!playerInSightRange && !playerInAttackRange) Patroling ();
        if(playerInSightRange && !playerInAttackRange) ChasePlayer();
        if(playerInAttackRange && playerInSightRange) AttackPlayer();
    }


    private void Patroling()
    {
            if (!walkPointSet) SearchWalkPoint();

            if (walkPointSet)
                agent.SetDestination(WalkPoint);

            Vector3 distanceToWalkPoint = transform.position - WalkPoint;

            if(distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;

    }

    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        WalkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        

        if (Physics.Raycast(WalkPoint, -transform.up, 2f, WhatIsGround))
        walkPointSet = true; 

    }

  private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

  private void AttackPlayer()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {

            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            SoundMenager.instance.Play(enemyshoot);

            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 4f, ForceMode.Impulse);



            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }



    }


     private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }



    private void ResetAttack ()
    {
            alreadyAttacked = false;
    }

    /*
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore += gruntValue;
            Die();
        }
    }
    void Die ()
    {
        Debug.Log("umar");
        Destroy(gameObject);
    }

    */

}