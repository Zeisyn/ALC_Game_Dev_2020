using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 0.08f;
    private float spawnRangeX = -9;
    private float spawnPosZ = 9;
    
    //starts InvokeRepeating with a delay and Interval
    private void Start()
    {
        InvokeRepeating("SpawnRandomEnemies", startDelay, spawnInterval);
    }
    
    //generates a position and spawns different enemies
    void SpawnRandomEnemies()
    {
        
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.3f, spawnPosZ);

            int enemyIndex = Random.Range(0, enemyPrefabs.Length);

            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}