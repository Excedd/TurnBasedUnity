using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "RPG/Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public Stats stats;

    public CharacterData()
    {

    }
}