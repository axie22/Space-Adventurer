using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDown : MonoBehaviour
{
    private float speed = 7.0f;
    private gameOver gameOverScript;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScript = GameObject.Find("gameOverDetector").GetComponent<gameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOverScript.gameIsOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
