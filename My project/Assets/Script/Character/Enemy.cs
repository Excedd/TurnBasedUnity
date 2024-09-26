using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CharacterData characterData;

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
