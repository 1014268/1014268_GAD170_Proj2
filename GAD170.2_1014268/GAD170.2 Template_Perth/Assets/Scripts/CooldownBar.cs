using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CooldownBar : MonoBehaviour
{
    public float maxCooldown;
    public float cooldownTimer;
    public CharacterStats characterStats;

    void Awake()
    {
        //CharacterStats stats = GetComponent<CharacterStats>();
        maxCooldown = characterStats.cooldown;
        cooldownTimer = maxCooldown;
        
    }

    void Update()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }

        if (cooldownTimer < 0)
        {
            cooldownTimer = 0;
            Attack();
            cooldownTimer = maxCooldown;
        }
        Scale();
    }

    void Scale()
    {
        transform.localScale = new Vector3(cooldownTimer/maxCooldown, 1, 1);
    }
       
    
    void Attack()
    {
        Debug.Log("In theory... they just attacked...");
    }
}