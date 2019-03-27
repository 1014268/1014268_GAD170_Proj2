using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownBar : MonoBehaviour
{
    public float maxCooldown;
    public float cooldownTimer;
    public CharacterStats characterStats;
    public BattleLogic battleLogic;
    SpriteRenderer spriteRenderer;

    

    void Scale()
        //This function should adjust the cooldown timers size
    {
        transform.localScale = new Vector3(cooldownTimer/maxCooldown, 1, 1);
    }
/*      
    void Attack()
    {
        //Not sure if I need this line?
        //BattleLogic battleLogic = GetComponent<BattleLogic>();
        if(characterStats.faction == "hero")
        {

        }
        else
        {
            GetFirstHero
        }
    }
 */    
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
        }

        if (cooldownTimer < 0)
        {
            cooldownTimer = 0;
            //Attack();
            cooldownTimer = maxCooldown;
        }
        Scale();
    }
}