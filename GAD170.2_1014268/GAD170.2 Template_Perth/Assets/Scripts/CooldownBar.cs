using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownBar : MonoBehaviour
{
    public float maxCooldown;
    public float cooldownTimer;
    public CharacterStats characterStats;
    public BattleLogic battleLogic;
            

    void Scale()
        //This function should adjust the cooldown timers size
    {
        transform.localScale = new Vector3(cooldownTimer/maxCooldown, 1, 1);
    }
    
    void Attack()
    {
        if(characterStats.faction == "hero")
        {
            if (GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                float enemy1Health = GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().health;
                float enemyResist = GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().defence / 100f;
                float damage = characterStats.attack * enemyResist;
                GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                float enemy1Health = GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().health;
                float enemyResist = GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().defence / 100f;
                float damage = characterStats.attack * enemyResist;
                GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().alive == true)
            { 
                float enemy1Health = GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().health;
                float enemyResist = GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().defence / 100f;
                float damage = characterStats.attack * enemyResist;
                GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
        }
        else
        {
            if (GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                float enemy1Health = GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().health;
                float enemyResist = GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().defence / 100f;
                float damage = characterStats.attack * enemyResist;
                GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                float enemy1Health = GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().health;
                float enemyResist = GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().defence / 100f;
                float damage = characterStats.attack * enemyResist;
                GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                float enemy1Health = GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().health;
                float enemyResist = GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().defence / 100f;
                float damage = characterStats.attack * enemyResist;
                GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
        }
    }
    
    void Start()
    {
        maxCooldown = characterStats.cooldown;
        cooldownTimer = maxCooldown;

    }

    void Update()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
            if(characterStats.alive == false)
            {
                cooldownTimer = 0;
            }
        }

        if (cooldownTimer <= 0)
        {
            if (characterStats.alive == true)
            {
                cooldownTimer = 0;
                Attack();
                cooldownTimer = maxCooldown;
            }
            else
            {
                cooldownTimer = 0;
            }
        }
        Scale();
    }
}