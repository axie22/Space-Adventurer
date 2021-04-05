using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public bool gameIsOver = true; // = false;
    private GameManager gameOverText;
    public GameObject titleScreen;
    private spawnManager spawner;
    public GameObject difficult;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("Game Manager").GetComponent<GameManager>();
        gameIsOver = true;
        spawner = GameObject.Find("SpawnManger").GetComponent<spawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Enemy1") || other.CompareTag("Enemy2"))
        {
            gameIsOver = true;
            gameOverText.GameOver();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        gameIsOver = false;
        titleScreen.gameObject.SetActive(false);
    }
}
