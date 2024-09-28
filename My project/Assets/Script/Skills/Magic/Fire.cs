namespace Assets.Script.Skills.Magic
{
    public class Fire : SkillBase
    {
        private void OnEnable()
        {
            MagicDamage = 20;
            skillName = "Fire";
        }
    }
}