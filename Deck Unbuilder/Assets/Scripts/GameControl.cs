using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public HealthBar healthBar;

    float health;
    float maxHealth = 100f;

    public bool debugTakeDamage;

    void Awake()
    {
        health = maxHealth;
    }
    
    void Update()
    {
        if (debugTakeDamage)
        {
            debugTakeDamage = false;
            health -= 10f;
        }

        if (health < 0f) { health = 0f; }

        healthBar.SetHealth(health, maxHealth);
    }
}
