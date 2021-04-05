using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUp;
    private float spawnRangeX = 29;
    private float spawnPosZ = 23;
    private gameOver gameOverScript;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScript = GameObject.Find("gameOverDetector").GetComponent<gameOver>();
        InvokeRepeating("spawnPowerUp", 3.0f, 23.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
        if (gameOverScript.gameIsOver == false)
        {
            Instantiate(powerUp, spawnPos, powerUp.transform.rotation);
        }
    }
}
