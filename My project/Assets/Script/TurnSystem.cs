using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    private List<GameObject> TurneableCharacter { get; set; }

    void Start()
    {
        var listCharacters = GetComponent<ITurnBasedCharacter>(); 
        foreach (var character in listCharacters)
        {
            TurneableCharacter.Add(character);
        }
        
        Console.WriteLine(TurneableCharacter);
    }

    void Update()
    {

    }
}
