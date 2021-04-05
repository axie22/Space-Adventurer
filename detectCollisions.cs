using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    //public ParticleSystem explosion; implement once you can import the particle system
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Enemy1") || other.CompareTag("Enemy2"))
        {
            Destroy(gameObject); //Destroy the gameObject the script is attached to 
            Destroy(other.gameObject); //Destroy the gameObject that it collides with
            //Instantiate(explosion, other.transform.position, other.transform.rotation);
            if (other.CompareTag("Enemy"))
            {
                gameManager.UpdateScore(10);
            }
            else if (other.CompareTag("Enemy1"))
            {
                gameManager.UpdateScore(15);
            }
            else
            {
                gameManager.UpdateScore(5);
            }
        }
    }
}
