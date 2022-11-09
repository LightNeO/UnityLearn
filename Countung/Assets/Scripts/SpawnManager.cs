using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject egg;
    [SerializeField] private GameObject[] spawnPos;
    [SerializeField] private float spawnDelay = 1.0f;
    [SerializeField] private float spawnTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEgg", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEgg()
    {
        int randomPos = Random.Range(0, 4);
        Instantiate(egg, spawnPos[randomPos].transform.position, egg.transform.rotation);
    }
}
