using System.Collections.Generic;
using UnityEngine;

public static class EnemyPositionManager
{
    public static Dictionary<CharacterPosition, Vector3> GetEnemyPositions()
    {
        return new Dictionary<CharacterPosition, Vector3>()
        {
            { CharacterPosition.EnemyPosition1, new Vector3(0, 1, 10) },
            { CharacterPosition.EnemyPosition2, new Vector3(1.5f, 1, 10) },
            { CharacterPosition.EnemyPosition3, new Vector3(-1.5f, 1, 10) }
        };
    }
}

