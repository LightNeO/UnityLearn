using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private float swapnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerUp;

    void Start()
    
    {
        SpawnEnemyWave(waveNumber);
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);

            Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
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
