using UnityEngine;

public class Stats : ScriptableObject
{

    public int level;
    public int maxHealth;
    public int currentHealth;
    public int attack;
    public int defense;
    public int experience;

    public Stats(int level, int maxHealth, int attack, int defense)
    {
        this.level = level;
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.experience = 0;
    }

}
