using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private float swapnRange = 9.0f;
    void Start()
    {


        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float swapnPosX = Random.Range(-swapnRange, swapnRange);
        float swapnPosZ = Random.Range(-swapnRange, swapnRange);
        Vector3 randomPos = new Vector3(swapnPosX, 0, swapnPosZ);

        return randomPos;
    }
}
