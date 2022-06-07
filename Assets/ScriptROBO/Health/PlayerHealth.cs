using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
 
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject DeathScreen;
    public HealthBar healthbar;
    Component Script;

    void start ()
    {
     
     
        currentHealth = maxHealth;
        healthbar.SetmMaxHealth(maxHealth);
    }


    void update()
    {
       
    }


    public void DamagePlayer(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
        if (currentHealth <= 0f)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            DeathScreen.SetActive(true);
            GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().enabled = false;

        }
    }

    public void HealPlayer(int heal)
    {
        currentHealth += heal;

        healthbar.SetHealth(currentHealth);
    }

    



}
