using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 42.0f;
    private float bound = 30f;
    public GameObject rocketPrefab;
    private gameOver gameOverScript;
    public bool hasPowerUp = false;
    //public float lives; Implement player lives later

    // Start is called before the first frame update
    void Start()
    {
        gameOverScript = GameObject.Find("gameOverDetector").GetComponent<gameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > bound)
        {
            transform.position = new Vector3(bound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -bound)
        {
            transform.position = new Vector3(-bound, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        if (gameOverScript.gameIsOver == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

        Vector3 rocketPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);

        if (Input.GetKeyDown(KeyCode.Space) && gameOverScript.gameIsOver == false)
        {
            Instantiate(rocketPrefab, rocketPos, rocketPrefab.transform.rotation);
        }

        if (hasPowerUp == true && gameOverScript.gameIsOver == false)
        {
            Instantiate(rocketPrefab, rocketPos, rocketPrefab.transform.rotation);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(5); // countdown timer for power up
        hasPowerUp = false;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }

        //if (other.CompareTag("Enemy"))
        //{
            //lives --
            //in update method add if lives = 0 then gameIsOver = true;
        //}
    }

}
