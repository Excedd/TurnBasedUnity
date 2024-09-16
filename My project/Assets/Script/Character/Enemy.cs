using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CharacterData characterData;
    public AttackSkill attackSkill;

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
