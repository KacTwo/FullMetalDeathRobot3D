using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIeICoinsy : MonoBehaviour
{
    [SerializeField] float coinValue = 100;
    [SerializeField] float health = 1;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore += coinValue;
            Die();
        }
    }
    void Die()
    {
        Debug.Log("umar");
        Destroy(gameObject);
    }

}
