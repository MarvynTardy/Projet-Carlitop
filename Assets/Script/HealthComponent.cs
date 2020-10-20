using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
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

    void TakeDamage(int damage)
    {
        currentHealth -= damage; 
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
