using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 29;
    private float spawnPosZ = 23;
    private gameOver gameOverScript;
    public float spawnRate = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScript = GameObject.Find("gameOverDetector").GetComponent<gameOver>();
        InvokeRepeating("SpawnRandomAlien", 2, spawnRate); //invokes the method SpawnRandomAnimal()
        //Starts 2 seconds into the game and repeats evert spawnRate seconds
        //StartCoroutine(spawnTimeRoutine());
        //StartCoroutine() may work
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAlien()
    {
        int alienIndex = Random.Range(0,alienPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),1,spawnPosZ);
        if(gameOverScript.gameIsOver == false)
        {
            Instantiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[alienIndex].transform.rotation);
        }
    }

    IEnumerator spawnTarget()
    {
        if (gameOverScript.gameIsOver == false)
        {
            yield return new WaitForSeconds(spawnRate); 
            int alienIndex = Random.Range(0, alienPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
            Instantiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[alienIndex].transform.rotation);
        }
        //Error: Doesn't work
        //Problem: Because the invoke repeating has to be in the start method, the spawn rate is stuck at the rate it's initialized at
    }
}
