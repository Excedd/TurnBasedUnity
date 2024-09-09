using UnityEngine;

public abstract class SkillBase : ScriptableObject
{
    public string skillName;
    public abstract void Execute(GameObject user);
}