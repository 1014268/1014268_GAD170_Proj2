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
   

    void Start()
    {
        maxHealth = health;
        cooldown = (10 - 10 * speed / 100);
    }

    public virtual void Die()
    {
        //Die in some way - this is meant to be overwritten
        Debug.Log("Oh no! " + myName + " has died!");
    }
}
