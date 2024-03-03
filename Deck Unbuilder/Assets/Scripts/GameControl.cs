using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public HealthBar healthBar;

    float health;
    float maxHealth = 100f;

    public bool debugTakeDamage;
    public GameOverScreen GameOverScreen;
    public GameObject CardUsed;

    void Awake()
    {
        health = maxHealth;
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

        if (health < 0f) { health = 0f; }
        else if (health > maxHealth) {  health = maxHealth; }
        else if (health < maxHealth / 2) { GameOver(); }
        healthBar.SetHealth(health, maxHealth);
    }

    public void TakeDamage(float damage)
    {
        health += damage;
    }

    public void GameOver()
    {
        GameOverScreen.Setup();
        CardUsed.SetActive(true);
    }
}
