using System;
using System.Linq;
using UnityEngine;

public class CharacterGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    [SerializeField]
    public int numberOfEnemies;

    void Start()
    {
        Debug.LogWarning("1");

        var enemiesPositions = EnemyPositionManager.GetEnemyPositions().ToArray();

        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 spawnPosition = enemiesPositions[i].Value;

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
