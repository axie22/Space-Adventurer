using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    private float farBound = 40.0f;
    private float bottomBound = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroying objects out of player's view
        if(transform.position.z > farBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
