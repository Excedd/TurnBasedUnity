using Assets.Script.Skills.Magic;
using System.Collections.Generic;
using UnityEngine;

public class Hero1 : MonoBehaviour, ITurnBasedCharacter
{
    public CharacterData characterData;
    public IList<SkillBase> skills = new List<SkillBase>();

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
        if (characterData == null)
        {
            characterData.stats = new(20);
        }

        if (skills == null)
        {
            skills.Add(ScriptableObject.CreateInstance<Fire>());
            
        }
    }

    void Update()
    {

    }
}
