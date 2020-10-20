using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
    }

     public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Heal(int heal)
    {
        currentHealth = +heal;
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
