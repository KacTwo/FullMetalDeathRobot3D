using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
 
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthbar;

    void start ()
    {
     
     
        currentHealth = maxHealth;
        healthbar.SetmMaxHealth(maxHealth);
    }


    void update()
    {
       if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Sklep1");
                }
    }


    public void DamagePlayer(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    public void HealPlayer(int heal)
    {
        currentHealth += heal;

        healthbar.SetHealth(currentHealth);
    }

    



}
