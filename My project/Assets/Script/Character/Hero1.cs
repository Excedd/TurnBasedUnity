using System.Collections.Generic;
using UnityEngine;

public class Hero1 : MonoBehaviour, ITurnBasedCharacter
{
    public CharacterData characterData;
    public List<SkillBase> skills;

    public string GetName()
    {
        return characterData.name;
    }

    public int GetVelocity()
    {
        return characterData.stats.velocity;
    }

    void Start()
    {
        if (characterData != null)
        {
            characterData.stats = new(20);
        }
    }

    void Update()
    {

    }
}
