using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CooldownBar : MonoBehaviour
{
    public float cooldown = 10;
    public float cooldownTimer;
    public GameObject Speed;

    void Start()
    {
        cooldownTimer = cooldown;
        
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
            cooldownTimer = cooldown;
        }
        Scale();
    }

       void Scale()
    {
        transform.localScale = new Vector3(cooldownTimer/cooldown, 1, 1);
    }
       
    
    void Attack()
    {
        Debug.Log("In theory... they just attacked...");
    }
}