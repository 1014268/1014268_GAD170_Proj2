using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //Assigns variables relevant to the healthbar functions
    public float maxHealth;
    public float health;
    public CharacterStats characterStats;
    public BattleLogic battleLogic;

    //This function should set everyones health bar maximum 
    void Start()
    {
        maxHealth = characterStats.health;
    }

    //This function should scale the health bar according to their percentage of health
    void Scale()
    {
        health = characterStats.health;
        if (health <= 0)
        {
            characterStats.health = 0;
            Die();
        }
        transform.localScale = new Vector3(health/maxHealth, 1, 1);
    }

    //This function should trigger a character death
    void Die()
    {
        characterStats.alive = false;
    }

    //This function should scale the health bart every frame
    private void Update()
    {
        Scale();
    }
}