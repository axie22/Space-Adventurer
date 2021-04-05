using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficultyButton : MonoBehaviour
{
    private Button button;
    private gameOver gameState;
    public int difficulty;
    //private spawnManager spawner;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameState = GameObject.Find("gameOverDetector").GetComponent<gameOver>();
        //spawner = GameObject.Find("SpawnManger").GetComponent<spawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name);
        gameState.StartGame();
        //spawner.spawnRate /= difficulty;
    }
}
