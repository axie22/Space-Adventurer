using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float rotationSpeed;
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
            transform.Rotate(Vector3.forward * rotationSpeed);
        }
    }
}