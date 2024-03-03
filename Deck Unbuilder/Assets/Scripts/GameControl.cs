using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public HealthBar healthBar;

    float health;
    float originalhealth = 10f;
    float maxHealth = 22f;

    public bool debugTakeDamage;
    public GameOverScreen GameOverScreen;
    public GameObject CardUsed;

    void Awake()
    {
        health = originalhealth;
    }

    void Start()
    {
        healthBar.SetHealth(health, maxHealth);
    }

    void Update()
    {
        if (debugTakeDamage)
        {
            debugTakeDamage = false;
            TakeDamage(-10f);
        }

        if (health <= 0f) { GameOver(); }
        else if (health > maxHealth) {  health = maxHealth; }
        healthBar.SetHealth(health, maxHealth);
    }

    public void TakeDamage(float damage)
    {
        health += damage;
    }

    public void GameOver()
    {
        GameOverScreen.Setup();
    }
}
