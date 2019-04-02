using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownBar : MonoBehaviour
{
    public float maxCooldown;
    public float cooldownTimer;
    public CharacterStats characterStats;
    public BattleLogic battleLogic;
    private bool gameEnd;
    string winner;
            

    void Scale()
        //This function should adjust the cooldown timers size
    {
        transform.localScale = new Vector3(cooldownTimer/maxCooldown, 1, 1);
    }
    
    void Attack()
    {
        float damage = 0f;
        float enemy1Health;
        float enemyResist;
        float hero1Health;
        float heroResist;
        if(characterStats.faction == "hero")
        {
            if (GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                enemy1Health = GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().health;
                enemyResist = GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().defence / 100f;
                damage = characterStats.attack * enemyResist;
                GameObject.Find("Enemy1(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                enemy1Health = GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().health;
                enemyResist = GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().defence / 100f;
                damage = characterStats.attack * enemyResist;
                GameObject.Find("Enemy2(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().alive == true)
            { 
                enemy1Health = GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().health;
                enemyResist = GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().defence / 100f;
                damage = characterStats.attack * enemyResist;
                GameObject.Find("Enemy3(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else
            {
                winner = "Good Guys!";
                gameEnd = true;
            }

            if (gameEnd == false)
            {
                WriteText aa = Object.FindObjectOfType<WriteText>();
                aa.OutputText(characterStats.myName + " dealt " + damage + " damage to the enemy!");
            }
            else
            {
                WriteText aa = Object.FindObjectOfType<WriteText>();
                aa.OutputText("Woohoo! The good guys won!");
            }

        }
        else
        {
            if (GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                hero1Health = GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().health;
                heroResist = GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().defence / 100f;
                damage = characterStats.attack * heroResist;
                GameObject.Find("Hero1(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                hero1Health = GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().health;
                heroResist = GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().defence / 100f;
                damage = characterStats.attack * heroResist;
                GameObject.Find("Hero2(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else if (GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().alive == true)
            {
                hero1Health = GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().health;
                heroResist = GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().defence / 100f;
                damage = characterStats.attack * heroResist;
                GameObject.Find("Hero3(Clone)").GetComponent<CharacterStats>().health -= (int)damage;
            }
            else
            {
                gameEnd = true;
            }

            if (gameEnd == false)
            {
                WriteText aa = Object.FindObjectOfType<WriteText>();
                aa.OutputText(characterStats.myName + " dealt " + damage + " damage to the heroes!");
            }
            else
            {
                WriteText aa = Object.FindObjectOfType<WriteText>();
                aa.OutputText("Oh no! The bad guys won!");
            }

            
        }
    }

    
    void Start()
    {
        maxCooldown = characterStats.cooldown;
        cooldownTimer = maxCooldown;
        gameEnd = false;
    }


    void Update()
    {

        if(gameEnd == false)
        {
            if (cooldownTimer > 0)
            {
                cooldownTimer -= Time.deltaTime;
                if (characterStats.alive == false)
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
}