using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaWaveSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy1;
    [SerializeField]
    private GameObject Enemy2;

    [SerializeField]
    private float Enemy1Interval=3.5f;
    [SerializeField]
    private float Enemy2Interval=10f;





    private void OnDrawGizmos() {
        Gizmos.DrawSphere(transform.position, 1);
    }

    void Start()
    {
        StartCoroutine(spawnEnemy(Enemy1Interval,Enemy1));
        StartCoroutine(spawnEnemy(Enemy2Interval, Enemy2));
    }

    // Update is called once per frame
    

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy);
        StartCoroutine(spawnEnemy(interval, enemy));

    }





}
