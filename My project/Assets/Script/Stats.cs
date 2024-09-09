using UnityEngine;

public class Stats : ScriptableObject
{
    public int level;
    public int maxHealth;
    public int currentHealth;
    public int attack;
    public int defense;
    public int experience;
    public int velocity;

    public Stats(int _velocity)
    {
        velocity = _velocity; 
    }
}
