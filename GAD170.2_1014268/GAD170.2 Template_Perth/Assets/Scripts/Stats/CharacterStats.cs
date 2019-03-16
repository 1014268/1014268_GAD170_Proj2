using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int myName;
    public Sprite mySprite;

    //Base Stats
    public int health;
    public int attack;
    public int defence;
    public int spAttack;
    public int spDefence;
    public int speed;

    
    public int maxHealth { get; private set; }
    public int damage { get; private set; }
    public int resist { get; private set; }
    public int spellPower { get; private set; }
    public int spellResist { get; private set; }
    public int cooldown { get; private set; }

    public int currentHealth { get; private set; }

    void Awake()
    {
        maxHealth = health;
        currentHealth = maxHealth;
    }
    
    public void TakeDamage (int damage)
    {
        damage -= (resist / 100) * damage;

        currentHealth -= damage;
        Debug.Log("Ouch! " + myName + " just took " + damage + " damage!");

        if (currentHealth <=0 )
        {
            Die();
        }
    }


    public void TakeSpDamage(int spDamage)
    {
        currentHealth -= spDamage;
        Debug.Log("Ouch! " + myName + " just took " + spDamage + " spell damage!");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //Die in some way - this is meant to be overwritten
        Debug.Log("Oh no! " + myName + " has died!");
    }
}
