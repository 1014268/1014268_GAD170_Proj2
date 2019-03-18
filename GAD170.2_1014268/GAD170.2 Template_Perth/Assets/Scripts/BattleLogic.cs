using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleLogic : MonoBehaviour
{
    public CharacterStats[] heroes = new CharacterStats[3];
    public CharacterStats[] enemies = new CharacterStats[3];

    public Transform[] heroSpawnPoints = new Transform[3];
    public Transform[] enemySpawnPoints = new Transform[3];

    public GameObject[] heroPrefabs;
    public GameObject[] enemyPrefabs;


    void SpawnIn()
    {
        //change 'i' into something else?
        for (int i = 0; i < 3; i++)
        {
            Instantiate(heroPrefabs[i], heroSpawnPoints[i].position, Quaternion.identity);
        }
    }
}
