namespace Assets.Script.Skills.Physical
{
    public class Rampage : SkillBase
    {
        private void OnEnable()
        {
            PhysicalDamage = 20;
            skillName = "Rampage";
        }
    }
}