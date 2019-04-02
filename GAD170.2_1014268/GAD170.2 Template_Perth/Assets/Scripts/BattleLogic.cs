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
        //WriteText aa = Object.FindObjectOfType<WriteText>();
        //aa.OutputText("im gay");
    }

    void SpawnIn()
    {
        //I want to spawn in my hero prefabs
        for (int p = 0; p < 3; p++)
        {
            Instantiate(heroPrefabs[p], heroSpawnPoints[p].position, Quaternion.identity);
        }
        //I want to spawn in my enemy prefabs
        for (int p = 0; p < 3; p++)
        {
            Instantiate(enemyPrefabs[p], enemySpawnPoints[p].position, Quaternion.identity);
        }
    }
}
