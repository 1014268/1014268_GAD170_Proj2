using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public CharacterStats characterStats;
    public BattleLogic battleLogic;

    void Start()
    {
        maxHealth = characterStats.health;
    }

    void Scale()
    //This function should adjust the cooldown timers size
    {
        health = characterStats.health;
        if (health <= 0)
        {
            characterStats.health = 0;
            Die();
        }
        transform.localScale = new Vector3(health/maxHealth, 1, 1);
    }

    void Die()
    {
        characterStats.alive = false;
    }

    private void Update()
    {
        Scale();
    }
}