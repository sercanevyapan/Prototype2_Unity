using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public GameObject dogPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomDog", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        

        for (int i = 0; i < ballPrefabs.Length; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            Instantiate(ballPrefabs[i], spawnPos, ballPrefabs[i].transform.rotation);
        }
        // instantiate ball at random spawn location
        
    }

    void SpawnRandomDog()
    {
        Vector3 spawnPos = new Vector3(17,0,0);
        Instantiate(dogPrefabs, spawnPos, dogPrefabs.transform.rotation);
    }

}
