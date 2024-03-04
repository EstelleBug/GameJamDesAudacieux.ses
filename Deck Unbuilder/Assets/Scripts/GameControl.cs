using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class GameControl : MonoBehaviour
{
    public HealthBar healthBar;

    float health;
    float originalhealth = 10f;
    float maxHealth = 22f;

    public bool debugTakeDamage;
    public GameOverScreen GameOverScreen;
    public GameObject CardUsed;
    [SerializeField] private StudioEventEmitter DecreaseJauge;
    [SerializeField] private StudioEventEmitter IncreaseJauge;
    [SerializeField] private StudioEventEmitter UnhappyElse;
    [SerializeField] private StudioEventEmitter HappyElse;

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
    public float GetHealth() { return health; }

    public void TakeDamage(float damage)
    {
        health += damage;
        if (damage < 0)
        {
            DecreaseJauge.Play();
            UnhappyElse.Play();
        }
        else
        {
            IncreaseJauge.Play();
            HappyElse.Play();
        }
    }

    public void GameOver()
    {
        GameOverScreen.Setup();
    }

    public void RestartGame()
    {
        GameOverScreen.HideGameOver();

        if (CardUsed != null)
        {
            DropZone dropZone = CardUsed.GetComponent<DropZone>();

            if (dropZone != null)
            {
                dropZone.MoveCardsToDeck();
            }
            else
            {
                Debug.LogError("DropZone component not found on CardUsed GameObject.");
            }
        }
        else
        {
            Debug.LogError("CardUsed GameObject not found.");
        }
    }

    public void Win()
    {
        ScenesManager.instance.LoadScene(ScenesManager.Scene.Win);
    }
}
