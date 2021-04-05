using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienForward : MonoBehaviour
{
    public float speed;
    private gameOver gameOverScript;
    public int pointVal;

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
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
