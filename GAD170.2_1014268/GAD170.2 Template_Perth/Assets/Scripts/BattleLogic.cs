using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleLogic : MonoBehaviour
{
    public CharacterStats[] heroes = new CharacterStats[3];
    public CharacterStats[] enemies = new CharacterStats[3];

    public Transform[] heroSpawnPoints = new Transform[3];
    public Transform[] enemySpawnPoints = new Transform[3];

    public GameObject[] heroPrefabs = new GameObject[3];
    public GameObject[] enemyPrefabs = new GameObject[3];

    
    void Start()
    {
        SpawnIn();
    }

    void SpawnIn()
    {
        
        for (int p = 0; p < 3; p++)
        {
            Instantiate(heroPrefabs[p], heroSpawnPoints[p].position, Quaternion.identity);
        }

        for (int p = 0; p < 3; p++)
        {
            Instantiate(enemyPrefabs[p], enemySpawnPoints[p].position, Quaternion.identity);
        }
    }

    public GameObject GetFirstEnemy()
    {
        return enemyPrefabs[0];
    }
    
    public GameObject GetFirstHero()
    {
        return heroPrefabs[0];
    }
        
}
