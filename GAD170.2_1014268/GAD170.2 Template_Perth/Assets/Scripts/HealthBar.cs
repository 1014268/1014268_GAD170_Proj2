using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public CharacterStats characterStats;
    

    void TakeDamage(int damage)
    {
        currentHealth =- damage;
    }

    
    void Scale()
    {
        transform.localScale = new Vector3(currentHealth / maxHealth, 1, 1);
    }

    void Die()
    {
        if (currentHealth <=0)
        {
            Destroy(gameObject);
        }
    }
       
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = characterStats.health;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Scale();
        Die();
    }
}
