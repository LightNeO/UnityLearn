using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private float swapnRange = 9.0f;
    public int enemyCount;

    void Start()
    
    {
        SpawnEnemyWave(3);
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if(enemyCount == 0)
        {
            SpawnEnemyWave(1);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float swapnPosX = Random.Range(-swapnRange, swapnRange);
        float swapnPosZ = Random.Range(-swapnRange, swapnRange);
        Vector3 randomPos = new Vector3(swapnPosX, 0, swapnPosZ);

        return randomPos;
    }
}
