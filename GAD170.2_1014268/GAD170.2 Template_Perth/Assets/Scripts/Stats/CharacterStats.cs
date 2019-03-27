using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public string myName;
    public string faction;
    public Sprite mySprite;

    //Base Stats
    public int health;
    public int attack;
    public int defence;
    public int spAttack;
    public int spDefence;
    public int speed;

    public int maxHealth { get; private set; }
    public int cooldown { get; private set; }
    public int currentHealth { get; private set; }

    void Start()
    {
        maxHealth = health;
        currentHealth = maxHealth;
        cooldown = (10 - 10 * speed / 100);
    }

        void TakeDamage(int damage)
    {
        currentHealth = -damage;

        //if currentHealth <= 0 Die
    }


    void Scale()
    {
        transform.localScale = new Vector3(currentHealth / maxHealth, 1, 1);
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
