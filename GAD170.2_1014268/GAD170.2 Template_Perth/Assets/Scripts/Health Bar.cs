using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public CharacterStats characterStats;
    

    void TakeDamage(int damage)
    {
        currentHealth =- damage;

        //if currentHealth <= 0 Die
    }

    
    void Scale()
    {
        transform.localScale = new Vector3(currentHealth / maxHealth, 1, 1);
    }
       
    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = characterStats.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Scale();
    }
}
