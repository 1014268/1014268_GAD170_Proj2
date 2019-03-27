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

    public GameObject GetFirstEnemy(GameObject firstEnemy)
    {
        GameObject returnThis = null;
        //I want to grab the first enemy, if it exists
        if (enemyPrefabs[0] != null)
        {
            returnThis =  enemyPrefabs[0];
        }
        //I want to grab the second enemy, if it exists
        else if (enemyPrefabs[1] != null)
        {
            returnThis = enemyPrefabs[1];
        }
        //I want to grab the third enemy, if it exists
        else if (enemyPrefabs[2] != null)
        {
            returnThis = enemyPrefabs[2];
        }
        //I want to add a win function here....
        return returnThis;

        Debug.Log(firstEnemy);
    }
    
    
    public GameObject GetFirstHero(GameObject firstHero)
    {
        GameObject returnThis = null;
        //I want to grab the first hero, if it exists
        if (heroPrefabs[0] != null)
        {
            returnThis = heroPrefabs[0];
        }
        //I want to grab the second hero, if it exists
        else if (heroPrefabs[1] != null)
        {
            returnThis = heroPrefabs[1];
        }
        //I want to grab the third hero, if it exists
        else if (heroPrefabs[2] != null)
        {
            returnThis = heroPrefabs[2];
        }
        //I want to add a win function here....
        return returnThis;
    }
    
}
