using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING};


    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves; 
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown;

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;


    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }



    private void Update()
    { 

            if ( state == SpawnState.WAITING)
            {
                if (!EnemyisAlive())
                {
                    // Begin a new round Add money
                    Debug.Log("Wave Completed!");
                } 
                else
                {
                   return;
                } 
            }
        



        if ( waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                // Spawn wave
                StartCoroutine ( SpawnWave(waves[nextWave]) );

            }
        else
        {
            waveCountdown -= Time.deltaTime;
        }

        }

        bool EnemyisAlive()
        {
            searchCountdown -= Time.deltaTime;
            if(searchCountdown <= 0f)
            {
                searchCountdown = 1f;
                if (GameObject.FindGameObjectWithTag("Enemy") == null)
                {
                 return false;
                }
            }
            return true; 
        }

        IEnumerator SpawnWave(Wave _Wave)
        {
            state = SpawnState.SPAWNING;
            
            for (int i = 0; i < _Wave.count; i++)
            {
                SpawnEnemy(_Wave.enemy);
                yield return new WaitForSeconds(1f/_Wave.rate);
            }

            state = SpawnState.WAITING;

            yield break;
        }

        void SpawnEnemy(Transform _enemy)
        {
            Instantiate (_enemy, transform.position, transform.rotation);
            Debug.Log("Spawning Enemy: " + _enemy.name );
        }
    }






}
