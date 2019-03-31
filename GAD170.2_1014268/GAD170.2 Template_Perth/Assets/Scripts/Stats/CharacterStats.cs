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
    public int currentHealth;
    public bool alive;
    public int cooldown;
    

    void Start()
    {
        maxHealth = health;
        currentHealth = maxHealth;
        alive = true;
        cooldown = (10 - 10 * speed / 100);        
    }

    
    private void Update()
    {
        if(alive == false)
        {
            if(faction == "hero")
            {
                transform.localRotation = Quaternion.Euler(0, 0, 90);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 0, 270);
            }
        }
    }
    
}