using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    private List<ITurnBasedCharacter> TurneableCharacter { get; set; }

    void Start()
    {
        var listCharacters = GetComponents<ITurnBasedCharacter>(); 
        foreach (var character in listCharacters)
        {
            TurneableCharacter.Add(character);
        }
        
    }

    void Update()
    {

    }

}
