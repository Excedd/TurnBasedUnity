using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Skill", menuName = "Skills/Attack")]
public class AttackSkill : SkillBase
{
    public override void Execute(GameObject user)
    {
        Debug.Log(user.name + " uses " + skillName + " to attack!");
    }
}